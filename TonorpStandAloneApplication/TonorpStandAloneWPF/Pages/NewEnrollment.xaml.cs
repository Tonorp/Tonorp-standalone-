using System;
using Futronic.SDKHelper;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TonorpStandAlone.Core.Logic;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAlone.Core.ViewModel;
using TonorpStandAloneWPF.Logic;
using TonorpStandAloneWPF.ViewModel;
using Brushes = System.Windows.Media.Brushes;
using System.Windows.Automation.Provider;
using TonorpStandAloneWPF.Pages.Dialogs;
using System.IO;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for NewEnrollment.xaml
    /// </summary>
    public partial class NewEnrollment
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NewEnrollment()
        {
            InitializeComponent();

            // Setting the User whoes enrollment is currently active
            _activeUser = EnrollmentOperations.GetActiveUser();

            // Sets the list of finger thumbnails for the user 
            // currently being enrolled
            SetActiveThumbnails();

            // Sets the Itemsourse of Finger thumbnail ItemControl
            FingerThumbnail.ItemsSource = _activeThumnails;

            // Triggers click event of BtnShowTemplate which in turn Sets template image for 
            // User's finger which already has template due to previous enrollment
            ButtonAutomationPeer peer = new ButtonAutomationPeer(BtnShowTemplate);
            IInvokeProvider invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
            invokeProv?.Invoke();

            DataContext = this;
        }

        #endregion

        #region Private Members

        /// <summary>
        /// The parent window that's hosting this Page
        /// </summary>
        private Window _parentWindow;

        /// <summary>
        /// List of finger thumbnails of the active user
        /// </summary>
        private readonly List<FingerThumbnailImg> _activeThumnails = new List<FingerThumbnailImg>();

        /// <summary>
        /// The selected finger which its template is currently being updated
        /// </summary>
        private FingerVmList _activeFinger;

        /// <summary>
        /// Instance of active thumbnail button
        /// </summary>
        private Button _activeThumbnailBtn = new Button();

        /// <summary>
        /// Instance of Image tag within the active thumbnail button
        /// </summary>
        private System.Windows.Controls.Image _activeImage = new System.Windows.Controls.Image();

        /// <summary>
        /// Instance of the TextBlock tag within the active thumbnail button
        /// </summary>
        private System.Windows.Controls.TextBlock _activeTextBlock = new System.Windows.Controls.TextBlock();

        /// <summary>
        /// Reference of current operation object
        /// </summary>
        private static FutronicSdkBase _currentOperation;

        /// <summary>
        /// The User whoes enrollment is currently active
        /// </summary>
        private readonly UserFingerVm _activeUser;

        #endregion

        #region Public Properties

        /// <summary>
        /// Active User's First name
        /// </summary>
        public string FirstName => _activeUser.User.FirstName;

        /// <summary>
        /// Active User's Last name
        /// </summary>
        public string LastName => _activeUser.User.LastName.ToUpper();

        /// <summary>
        /// Active User's Registration number
        /// </summary>
        public string RegNo => _activeUser.User.RegNo;

        /// <summary>
        /// Active User's Department
        /// </summary>
        public string Dept => _activeUser.User.Department;

        /// <summary>
        /// Active User's Level
        /// </summary>
        /// todo: add this property to UserFingerVm
        //public string Level => _activeUser.User.Level;

        #endregion

        #region Delegates

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the Image property on a PictureBox control.
        /// </summary>
        /// <param name="hBitmap">the instance of Bitmap class</param>
        delegate void SetImageCallback(Bitmap hBitmap);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the text property on a status control.
        /// </summary>
        /// <param name="text">The text to set</param>
        delegate void SetTextCallback(string text);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the percentage of active enrollment template.
        /// </summary>
        /// <param name="percentage">The percentage to set</param>
        delegate void SetPercentageCallback(string percentage);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the properties of a control.
        /// </summary>
        delegate void ControlsCallback();

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the Foreground color property of a textBlock.
        /// </summary>
        delegate void SetTxtForegroundColorCallback(TextBlock txt, string color);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the color property of a button.
        /// </summary>
        delegate void SetBtnColorCallback(Button button, string color);

        #endregion

        #region Button Click events

        /// <summary>
        /// Button Click event for change of fingerprint thumbnails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeThumbnails_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            if (_parentWindow != null)
            {
                // New instance of BaseWindowDialog to host this ChangeFingerprint Page
                BaseWindowDialog windowDialog = new BaseWindowDialog();

                // Populating page properties
                windowDialog.ViewModel.CurrentPage = ApplicationPage.ChangeFingers;
                windowDialog.ViewModel.PageTitle = "CHANGE OF FINGER REQUEST";
                windowDialog.Height = 660;
                windowDialog.Width = 1000;
                windowDialog.ViewModel.IsRestoreButtonVisible = true;

                // Setting the overlay of parent window to true

                ((WindowViewModel)_parentWindow.DataContext).IsWindowOverlayVisible = true;

                // Removing Parent window overlay on closing of this window
                windowDialog.Closing += (o, args) => ((WindowViewModel)_parentWindow.DataContext).IsWindowOverlayVisible = false;

                // Show the new window
                windowDialog.ShowDialog();
            }
        }

        /// <summary>
        /// Sets the image of user's finger which already has template 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowTemplate_Click(object sender, RoutedEventArgs e)
        {
            SetImageTemplate();
        }

        /// <summary>
        /// Click event of DONE button which indicates a particular User's enrollment
        /// has been completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnrollmentDone_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                // Getting the parent window
                _parentWindow = Window.GetWindow(this);

                // Check if window is null
                if (_parentWindow == null)
                    return;

                //Getting windows DataContext
                var viewModel = (WindowViewModel)_parentWindow?.DataContext;

                //Instantiating the window properties
                _parentWindow.Height = 660;
                _parentWindow.Width = 1200;
                viewModel.CurrentPage = ApplicationPage.NewEnrollmentOverlay;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Save file failure!");
            }
        }

        /// <summary>
        /// Click event of each thumbnail button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnThumbnail_Clicked(object sender, RoutedEventArgs e)
        {
            // The button which triggered this click event
            _activeThumbnailBtn = (Button)sender;

            //Set the active finger which is being enrolled
            _activeFinger = _activeUser?.Fingers?.FirstOrDefault(f => f.Finger.IndexNumber.ToString() == _activeThumbnailBtn.Tag.ToString());

            // Sets background of the active thumbnail button
            if (Application.Current.MainWindow != null)
                _activeThumbnailBtn.Background = (System.Windows.Media.Brush)Application.Current
                    .MainWindow.FindResource("GreenGrayBrush");

            // Sets Active image to the Image control within the current button
            _activeImage = FindVisualChildren<System.Windows.Controls.Image>(this)
                .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == _activeThumbnailBtn.Tag.ToString());

            // Sets Active TextBlock to the TextBlock control within the current button
            _activeTextBlock = FindVisualChildren<TextBlock>(this)
                .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == _activeThumbnailBtn.Tag.ToString());

            // Disables other thumbnail button except the active button
            DisThumbnailsExceptAct();

            try
            {
                // Starts enrollment for the selected finger
                StartEnrollment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Cancels Current enrollment operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelEnrollment_Clicked(object sender, RoutedEventArgs e)
        {
            // Cancel ongoing enrollment operation
            _currentOperation.OnCalcel();

            // Default the active thumbnail button background back to transparent
            _activeThumbnailBtn.Background = Brushes.Transparent;

            foreach (var thumbnail in _activeThumnails)
            {
                if (thumbnail.IndexNumber.ToString() == _activeImage.Tag.ToString())
                {
                    // Sets the image of active thumbnail back to its default
                    _activeImage.Source = new BitmapImage(new Uri(thumbnail.ImgPath, UriKind.RelativeOrAbsolute));
                }
            }

            // Set Active label foreground color
            SetLblForegroundColor(_activeTextBlock, "ForegroundMainBrush");

            // Sets ThumbnailLarge image source and height properties to default
            ThumbnailLarge.Height = 150;
            ThumbnailLarge.Source = new BitmapImage(new Uri("/Images/HandAndDevice.png", UriKind.RelativeOrAbsolute));

            // Defaulting label for enrollment percentage back to zero
            LblPercentage.Text = "0%";
        }

        //private void btnDone_Click(object sender, EventArgs e)
        //{
        //    FileInformation fileInfo = new FileInformation();
        //    try
        //    {
        //        var jsonString = _usersToEnrol.ConvertToJson();
        //        string path = FileInformation.GetLoggedInUserFileDirectory() + @"\UsersToEnrol.json";
        //        string errMsg;
        //        fileInfo.WriteFile(path, jsonString, out errMsg);
        //        MessageBox.Show("Fingerprint information saved succesfully!");
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message, "Save file failure!",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        #endregion

        #region Helper functions

        /// <summary>
        /// Sets the list of finger thumnails of the user currently being enrolled
        /// </summary>
        private void SetActiveThumbnails()
        {
            if (_activeUser.Fingers != null)
                foreach (FingerVmList finger in _activeUser.Fingers)
                {
                    switch (finger.Finger.IndexNumber)
                    {
                        case 1:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 1,
                                    ImgPath = "/Images/RightThumbImg.png",
                                    Name = "Right Thumb",
                                    Template = finger.Template
                                });
                            break;

                        case 2:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 2,
                                    ImgPath = "/Images/RightIndexImg.png",
                                    Name = "Right Index",
                                    Template = finger.Template
                                });
                            break;

                        case 3:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 3,
                                    ImgPath = "/Images/RightMiddleImg.png",
                                    Name = "Right Middle",
                                    Template = finger.Template
                                });
                            break;

                        case 4:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 4,
                                    ImgPath = "/Images/RightRingImg.png",
                                    Name = "Right Ring",
                                    Template = finger.Template
                                });
                            break;

                        case 5:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 5,
                                    ImgPath = "/Images/RightPinkyImg.png",
                                    Name = "Right Pinky",
                                    Template = finger.Template
                                });
                            break;

                        case 6:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 6,
                                    ImgPath = "/Images/LeftThumbImg.png",
                                    Name = "Left Thumb",
                                    Template = finger.Template
                                });
                            break;

                        case 7:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 7,
                                    ImgPath = "/Images/LeftIndexImg.png",
                                    Name = "Left Index",
                                    Template = finger.Template
                                });
                            break;

                        case 8:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 8,
                                    ImgPath = "/Images/LeftMiddleImg.png",
                                    Name = "Left Middle",
                                    Template = finger.Template
                                });
                            break;

                        case 9:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 9,
                                    ImgPath = "/Images/LeftRingImg.png",
                                    Name = "Left Ring",
                                    Template = finger.Template
                                });
                            break;

                        case 10:
                            if (_activeThumnails.FirstOrDefault(t => t.IndexNumber == finger.Finger.IndexNumber) == null)
                                _activeThumnails.Add(new FingerThumbnailImg
                                {
                                    IndexNumber = 10,
                                    ImgPath = "/Images/LeftPinkyImg.png",
                                    Name = "Left Pinky",
                                    Template = finger.Template
                                });
                            break;
                    }
                }
        }

        /// <summary>
        /// If User has previously enrolled for the current finger, it Set the image
        /// of that finger thumbnail to a fingerprint image
        /// </summary>
        private void SetImageTemplate()
        {
            foreach (var thumbnail in _activeThumnails)
            {
                var index = thumbnail.IndexNumber.ToString();

                // Gets the current button thumbnail which this loop is on
                Button btn = FindVisualChildren<Button>(this)
                    .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == index);

                // Gets the Image control within the current button
                System.Windows.Controls.Image img = FindVisualChildren<System.Windows.Controls.Image>(this)
                   .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == index);

                // Gets the Textblock control within the current button
                TextBlock txtBlock = FindVisualChildren<TextBlock>(this)
                   .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == index);

                if (thumbnail.Template == null || img == null)
                    continue;

                // Set textBlock foreground color
                if (txtBlock != null)
                    SetLblForegroundColor(txtBlock, "SoftOffWhiteBrush");

                // Set button background color
                if (btn != null)
                    SetBtnBackgroundColor(btn, "GreenGrayBrush");

                // Sets image source of the fingerprint thumbnail which already has a template
                img.Source = new BitmapImage(new Uri("/Images/fingerprint.png", UriKind.RelativeOrAbsolute));


            }
        }

        /// <summary>
        /// Gets children control of supplied Type within the Page
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="depObj"></param>
        /// <returns></returns>
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj == null) yield break;
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);
                var children = child as T;
                if (children != null)
                {
                    yield return children;
                }

                foreach (var childOfChild in FindVisualChildren<T>(child))
                {
                    yield return childOfChild;
                }
            }
        }

        /// <summary>
        /// Called on each finger to begin Enrollment process for that finger
        /// </summary>
        private void StartEnrollment()
        {
            if (_currentOperation != null)
            {
                _currentOperation.Dispose();
                _currentOperation = null;
            }

            _currentOperation = new FutronicEnrollment
            {
                FFDControl = true,
                FARN = 166,
                Version = VersionCompatible.ftr_version_current
            };

            // Set properties
            ((FutronicEnrollment)_currentOperation).MaxModels = 3;
            _currentOperation.MinMinuitaeLevel = 2;
            _currentOperation.MinOverlappedLevel = 4;

            // register events
            _currentOperation.OnPutOn += OnPutOn;
            _currentOperation.OnTakeOff += OnTakeOff;
            _currentOperation.UpdateScreenImage += UpdateScreenImage;
            ((FutronicEnrollment)_currentOperation).OnEnrollmentComplete += OnEnrollmentComplete;

            //start enrollment process
            ((FutronicEnrollment)_currentOperation).Enrollment();
        }

        /// <summary>
        /// Saves Fingerprint template to UsersToEnroll file
        /// </summary>
        /// <param name="temp">The fingerprint template to save</param>
        /// <returns></returns>
        private bool SaveFingerprint(byte[] temp)
        {
            // Getting the finger whose template is to be saved
            if (_activeUser?.Fingers?.FirstOrDefault(a => a.Finger.IndexNumber == _activeFinger.Finger.IndexNumber) != null)
            {
                #region Save template to UsersToEnrol file in program memory
                // Variable to hold User currently being enrolled
                var user = EnrollmentOperations.GetUsersToEnrol().Users
                    .FirstOrDefault(x => x.User.Id == _activeUser.User.Id);

                // The User's particular finger which is being enrolled
                var finger = user?.Fingers.FirstOrDefault(p => p.Finger.IndexNumber == _activeFinger.Finger.IndexNumber);

                if (finger != null)
                    // Assign gotten template to User's active finger
                    finger.Template = temp;
                #endregion

                #region Save template to UsersToEnrol file in a path in User's PC
                // Convert UsersToEnrol to JSON string
                var jsonString = EnrollmentOperations.GetUsersToEnrol().ConvertToJson();

                // The path in user's PC to save UsersToEnrol JSON file
                string path = FileInformation.GetLoggedInUserFileDirectory() + @"\UsersToEnrol.json";
                string errMsg;

                // Saving UsersToEnrol JSON file to the specified path
                FileInformation fileInfo = new FileInformation();
                if (fileInfo.WriteFile(path, jsonString, out errMsg))
                {
                    MessageBox.Show("Fingerprint template saved succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to save fingerprint template");
                    return false;
                }
                #endregion
            }
            return false;
        }

        /// <summary>
        /// Sets the status text of fingerprint enrollment process
        /// </summary>
        /// <param name="text"></param>
        private void SetStatusText(string text)
        {

            if (!Dispatcher.CheckAccess())
            {
                var d = new SetTextCallback(SetStatusText);
                Dispatcher.BeginInvoke(d, text);
            }
            else
            {
                EnrLabel.Text = text;
            }

        }

        /// <summary>
        /// Sets the quality of template gotten in each finger enrollment in percentage
        /// </summary>
        /// <param name="percentage"></param>
        private void SetEnrolPercentage(string percentage)
        {
            if (!Dispatcher.CheckAccess())
            {
                var d = new SetPercentageCallback(SetEnrolPercentage);
                Dispatcher.BeginInvoke(d, percentage);
            }
            else
            {
                //SetPercentageCallback
                LblPercentage.Text = percentage;
            }
        }

        /// <summary>
        /// Sets the Foreground color of the passed in TextBlock
        /// </summary>
        /// <param name="label">the TextBlock which its foreground should be changed</param>
        /// <param name="color">The Color</param>
        private void SetLblForegroundColor(TextBlock label, string color)
        {
            if (!Dispatcher.CheckAccess())
            {
                var d = new SetTxtForegroundColorCallback(SetLblForegroundColor);
                Dispatcher.BeginInvoke(d, label, color);
            }
            else
            {
                // Sets the foreground color of the passed in TextBlock
                if (Application.Current.MainWindow != null)
                {
                    if (label != null)
                        label.Foreground = (System.Windows.Media.Brush)Application.Current
                            .MainWindow.FindResource(color);
                }
            }
        }

        /// <summary>
        /// Sets the Background color of the passed in Button
        /// </summary>
        /// <param name="button">the Button which its background color should be changed</param>
        /// <param name="color">The Color</param>
        private void SetBtnBackgroundColor(Button button, string color)
        {
            if (!Dispatcher.CheckAccess())
            {
                var d = new SetBtnColorCallback(SetBtnBackgroundColor);
                Dispatcher.BeginInvoke(d, button, color);
            }
            else
            {
                // Sets the background color of the passed in button
                if (Application.Current.MainWindow != null)
                {
                    if (button != null)
                        button.Background = (System.Windows.Media.Brush)Application.Current
                            .MainWindow.FindResource(color);
                }
            }
        }

        /// <summary>
        /// Called on placing of finger on the scanner
        /// </summary>
        /// <param name="progress"></param>
        private void OnPutOn(FTR_PROGRESS progress)
        {
            SetStatusText("Put finger into device, please ...");
        }

        /// <summary>
        /// Called on taking finger off from scanner
        /// </summary>
        /// <param name="progress"></param>
        private void OnTakeOff(FTR_PROGRESS progress)
        {
            SetStatusText("Take off finger from device, please ...");
        }

        /// <summary>
        /// Updates the active thumbnail image to the fingerprint template image gotten from capture
        /// </summary>
        /// <param name="hBitmap"></param>
        private void UpdateScreenImage(Bitmap hBitmap)
        {
            // Converting passed Bitmap to BitmapImage
            BitmapImage img = hBitmap.ToBitmapImage();

            if (_activeImage == null || img == null)
                return;

            if (!Dispatcher.CheckAccess())
            {
                var d = new SetImageCallback(UpdateScreenImage);
                Dispatcher.BeginInvoke(d, hBitmap);
            }
            else
            {
                // Change image source within active button to the generated template
                _activeImage.Source = img;

                // Change image source within active button to the generated template
                ThumbnailLarge.Height = 300;

                // Change image source of ThumbnailLarge UI Control to the generated template
                ThumbnailLarge.Source = img;
            }
        }

        /// <summary>
        /// Called on the completion of each finger enrollment
        /// </summary>
        /// <param name="enrollmentSuccessful"></param>
        /// <param name="nRetCode"></param>
        private void OnEnrollmentComplete(bool enrollmentSuccessful, int nRetCode)
        {
            // Instance of string builder to hold enrollment message
            StringBuilder enrolmentMsg = new StringBuilder();

            if (enrollmentSuccessful)
            {
                // The percentage of template quality gotten from fingerprint enrollment
                string enrlPercentage = ((FutronicEnrollment)_currentOperation).Quality.ConvertToPercentage();

                // set status string
                enrolmentMsg.Append("Enrollment process finished successfully.");
                enrolmentMsg.Append(" Quality: ");
                enrolmentMsg.Append(enrlPercentage);
                SetStatusText(enrolmentMsg.ToString());

                //Set fingerprint enrollment percentage label
                SetEnrolPercentage(enrlPercentage);

                // Set Active label foreground color
                SetLblForegroundColor(_activeTextBlock, "SoftOffWhiteBrush");

                // Set gotten template into active user's information and then save it to ext file
                if (!SaveFingerprint(((FutronicEnrollment)_currentOperation)?.Template))
                    MessageBox.Show("Could not save fingerprint template!");

                // todo : Write code to save user information
            }
            else
            {
                enrolmentMsg.Append("Enrollment process failed.");
                enrolmentMsg.Append("Error description: ");
                enrolmentMsg.Append(FutronicSdkBase.SdkRetCode2Message(nRetCode));
                SetStatusText(enrolmentMsg.ToString());
            }

            // unregister events and enable thumnails
            if (_currentOperation != null)
            {
                _currentOperation.OnPutOn -= OnPutOn;
                _currentOperation.OnTakeOff -= OnTakeOff;
                _currentOperation.UpdateScreenImage -= UpdateScreenImage;
                ((FutronicEnrollment)_currentOperation).OnEnrollmentComplete -= OnEnrollmentComplete;

                EnableThumbnails();

            }
        }

        /// <summary>
        /// Enables finger thumbnails
        /// </summary>
        private void EnableThumbnails()
        {
            if (!Dispatcher.CheckAccess())
            {
                var d = new ControlsCallback(EnableThumbnails);
                Dispatcher.BeginInvoke(d);
            }
            else
            {
                foreach (var thumbnail in _activeThumnails)
                {
                    var tagName = thumbnail.IndexNumber.ToString();

                    // Gets the button which this loop is currently on
                    Button btn = FindVisualChildren<Button>(this)
                        .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == tagName);

                    if (btn != null) btn.IsEnabled = true;
                }

                // Enables the DONE button
                BtnDone.IsEnabled = true;

                // Enables the Cancel button
                BtnCancel.IsEnabled = false;
            }
        }

        /// <summary>
        /// Disables finger thumbnails except the active one
        /// also sets the active image <see cref="_activeImage"/> under active finger thumbnail button
        /// </summary>
        private void DisThumbnailsExceptAct()
        {
            foreach (var thumbnail in _activeThumnails)
            {
                var tagName = thumbnail.IndexNumber.ToString();

                // Gets the button which this loop is currently on
                Button btn = FindVisualChildren<Button>(this)
                    .FirstOrDefault(x => x.Tag != null && x.Tag.ToString() == tagName);


                if (btn != null && btn.Tag == _activeThumbnailBtn.Tag)
                {
                    // Enables active button and disables the rest
                    btn.IsEnabled = true;
                }
                else
                {
                    if (btn != null) btn.IsEnabled = false;
                }
            }

            // Disables the DONE button
            BtnDone.IsEnabled = false;

            // Enables the Cancel button
            BtnCancel.IsEnabled = true;
        }

        /// <summary>
        /// Methods called on Back button of NewEnrollment Window
        /// </summary>
        private void InitContinueEnrollment()
        {
            var contEnrol = Window.GetWindow(this);
            if (contEnrol == null) return;
            var viewModel = (WindowViewModel)contEnrol.DataContext;
            viewModel.CurrentPage = ApplicationPage.ContinueEnrollment;
            viewModel.PageTitle = "Continue Enrollment Page - Tonorp Attendance";
            viewModel.WindowStartLoc = WindowStartupLocation.CenterScreen;
            contEnrol.Height = 650;
            contEnrol.Width = 1200;
        }

        #endregion
    }
}
