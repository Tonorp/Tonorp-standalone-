using System;
using System.Windows;
using System.Windows.Controls;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAlone.Core.ViewModel;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for NewEnrollmentParametersStaff.xaml
    /// </summary>
    public partial class NewEnrollmentParametersStaff
    {
        /// <summary>
        /// Window Instance to hold the application window
        /// </summary>
        private Window _parentWindow;

        /// <summary>
        /// Default constructor
        /// </summary>
        public NewEnrollmentParametersStaff()
        {
            InitializeComponent();
            CmbCampusStaff.ItemsSource = new CampusVm().GetCampusInfoList();

        }

        #region Button Click events

        /// <summary>
        /// Action performed when Begin enrollment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BeginEnrollment_Clicked(object sender, RoutedEventArgs e)
        {
            // Instance of the Application window
            _parentWindow = GetWindow("AppWindow");
            if (_parentWindow == null)
                return;

            // Instance of the window hosting this page
            var activeWindow = Window.GetWindow(this);
            if (activeWindow == null)
                return;

            // close active page
            activeWindow.Close();

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
            viewModel.IsWindowOverlayVisible = false;


        }

        #endregion


        #region Helper methods

        /// <summary>
        /// Window the Window with the supplied title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private Window GetWindow(string title)
        {
            Window win = null;
            foreach (Window currentWindow in Application.Current.Windows)
            {
                if (currentWindow.Name.Equals(title, StringComparison.OrdinalIgnoreCase))
                    win = currentWindow;
            }
            return win;

        }

        /// <summary>
        /// Methods called on Closing of NewEnrollment Window
        /// </summary>
        private void InitializeContEnrol()
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
