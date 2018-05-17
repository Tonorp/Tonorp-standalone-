using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAlone.Core.ViewModel;
using TonorpStandAloneWPF.Pages.Dialogs;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for ContinueEnrollment.xaml
    /// </summary>
    public partial class ContinueEnrollment
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ContinueEnrollment()
        {
            InitializeComponent();

            // Getting list of Continue enrollment items
            _contEnrollmentItems = new ContinueEnrollmentVm().GetContEnrInfo();

            if (_contEnrollmentItems.Count != 0)
            {
                // Setting Item source of Continue Enrollment ListBox
                ContEnrItems.ItemsSource = _contEnrollmentItems;

                // Set continue enrollment table selected index to the first index
                SetSelectedIndex();
            }

            // Check if Continue enrollment has record
            CheckContEnrolRecord();
        }

        #endregion

        #region Private Members

        /// <summary>
        /// The parent window that's hosting this Page
        /// </summary>
        private Window _parentWindow;

        /// <summary>
        /// List of Continue enrollment items
        /// </summary>
        private readonly List<ContinueEnrollmentVm> _contEnrollmentItems;
        #endregion

        #region Public Properties

        /// <summary>
        /// The table seleced item
        /// </summary>
        public ContinueEnrollmentVm SelectedItem { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// On clicking of New Enrollment button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEnrollmentBtn_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            if (_parentWindow != null)
            {
                //Instance of BaseWindowDialog to host NewEnrollment Page
                BaseWindowDialog window = new BaseWindowDialog();

                //Instantiating the window properties
                window.ViewModel.CurrentPage = ApplicationPage.EnrollmentType;
                window.ViewModel.PageTitle = "SELECT ENROLLMENT TYPE";
                window.Height = 350;
                window.Width = 620;

                // Setting the overlay of parent window to true
                ((WindowViewModel)_parentWindow.DataContext).IsWindowOverlayVisible = true;

                // Removing Parent window overlay on closing of this window
                window.Closing += (o, args) => ((WindowViewModel)_parentWindow.DataContext).IsWindowOverlayVisible = false;


                //Show Enrollment Type Window
                window.ShowDialog();
            }
        }

        /// <summary>
        /// On clicking of Continue Enrollment button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contEnrBtn_Clicked(object sender, RoutedEventArgs e)
        {
            // Instance of the Application window
            _parentWindow = Window.GetWindow(this);
            if (_parentWindow == null)
                return;

            // Application window view model
            var viewModel = (WindowViewModel)_parentWindow.DataContext;

            // Instantiating the window properties
            viewModel.CurrentPage = ApplicationPage.NewEnrollmentOverlay;
            viewModel.PageTitle = "New Enrollment Page - Tonorp Attendance";
            _parentWindow.Height = 660;
            _parentWindow.Width = 1220;
            viewModel.IsRestoreButtonVisible = true;
            viewModel.IsNewEnrollmentButtonVisible = true;
            viewModel.IsLogoutButtonVisible = true;
            viewModel.IsInfoButtonVisible = true;
            viewModel.IsRestoreButtonVisible = true;
        }

        /// <summary>
        /// OnSelectionChanged event of continue enrollment table rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContEnrItems_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedItem = ContEnrItems.SelectedItem as ContinueEnrollmentVm;

            //Animation to show More Info Panel
            DoubleAnimation da = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            MoreInfoPanel.BeginAnimation(OpacityProperty, da);

            //Updating More Info Panel properties
            TxtAlias.Text = SelectedItem?.CampAlias;
            TxtCampName.Text = SelectedItem?.CampName;
            TxtDept.Text = SelectedItem?.Department;
            TxtLevel.Text = SelectedItem?.Level;
            TxtTotalRecord.Text = SelectedItem?.TotalRecord.ToString();
            TxtNoSucUploads.Text = SelectedItem?.NoSuccUploads.ToString();
            TxtNoRemaining.Text = SelectedItem?.NoRemaining.ToString();
            TxtNoWithoutTemp.Text = SelectedItem?.NoRemaining.ToString();
        }

        /// <summary>
        /// Click event to remove selected Continue enrollment listBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {

            foreach (var item in _contEnrollmentItems)
            {
                if (item.SerialNumber == SelectedItem.SerialNumber)
                {
                    // remove selected item
                    _contEnrollmentItems.Remove(item);

                    // Reseting ListBox item source
                    ContEnrItems.ItemsSource = _contEnrollmentItems;

                    // Refreshing ListBox UI items
                    ContEnrItems.Items.Refresh();

                    // Checking if Continue enrollment still has record
                    CheckContEnrolRecord();

                    //Setting Continue enrollment items selected index to the first index
                    SetSelectedIndex();
                    break;
                }
            }
        }

        #endregion

        #region Helper functions

        /// <summary>
        /// Checks if Continue enrollment has record and sets UI visibility of affected controls
        /// </summary>
        private void CheckContEnrolRecord()
        {
            // Toggle text and panel visibility
            if (_contEnrollmentItems.Count != 0)
            {
                if (_contEnrollmentItems.Count < 11)
                    SearchPanel.Visibility = Visibility.Collapsed;

                MoreInfoPanel.Visibility = Visibility.Visible;
                RecordText.Visibility = Visibility.Collapsed;
            }
            else
            {
                MoreInfoPanel.Visibility = Visibility.Collapsed;
                RecordText.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Setting Continue enrollment ListBox selected index to the first index
        /// </summary>
        private void SetSelectedIndex()
        {
            if (_contEnrollmentItems.Count != 0)
                ContEnrItems.SelectedIndex = 0;
        }

        #endregion
    }

}
