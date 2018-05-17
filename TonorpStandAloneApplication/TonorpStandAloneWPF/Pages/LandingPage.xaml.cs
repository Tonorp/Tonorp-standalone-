using System.Windows;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage
    {
        /// <summary>
        /// The parent window that's hosting this Page
        /// </summary>
        private Window _parentWindow;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LandingPage()
        {
            InitializeComponent();
        }

        #region Button Click events

        /// <summary>
        /// Enrollment Button Click event
        /// </summary>
        /// <param name="sender">The Caller of this event</param>
        /// <param name="e">The event arguement</param>
        private void Enrollment_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            // Check if window is null
            if (_parentWindow == null) return;

            //Getting windows DataContext
            var viewModel = (WindowViewModel)_parentWindow.DataContext;

            //Instantiating the window properties
            viewModel.CurrentPage = ApplicationPage.ContinueEnrollment;
            viewModel.PageTitle = "Continue Enrollment Page - Tonorp Enrollment Application";
            viewModel.IsClientLinkVisible = true;
            viewModel.IsNetworkVisible = true;
            viewModel.ResizeMode = ResizeMode.CanResize;
            viewModel.IsRestoreButtonVisible = true;
            _parentWindow.Height = 700;
            _parentWindow.Width = 1200;
            _parentWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _parentWindow.WindowState = WindowState.Maximized;
        }

        /// <summary>
        /// Assigned Campuses Button Click event
        /// </summary>
        /// <param name="sender">The Caller of this event</param>
        /// <param name="e">The event arguement</param>
        private void AssignedCampuses_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            // Check if window is null
            if (_parentWindow == null) return;

            // Getting window's DataContext
            var viewModel = (WindowViewModel)_parentWindow.DataContext;

            //Instantiating the window properties
            viewModel.CurrentPage = ApplicationPage.Campuses;
            viewModel.PageTitle = "Assigned Campuses Page - Tonorp Enrollment Application";
            viewModel.IsClientLinkVisible = true;
            viewModel.IsNetworkVisible = true;
            _parentWindow.Height = 700;
            _parentWindow.Width = 1220;
            viewModel.ResizeMode = ResizeMode.CanResize;
            viewModel.IsNewEnrollmentButtonVisible = true;
            viewModel.IsLogoutButtonVisible = true;
            viewModel.IsInfoButtonVisible = false;
            viewModel.IsRestoreButtonVisible = true;
            _parentWindow.WindowState = WindowState.Maximized;
            _parentWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        /// <summary>
        /// Upload status Button Click event
        /// </summary>
        /// <param name="sender">The Caller of this event</param>
        /// <param name="e">The event arguement</param>
        private void UploadStatus_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            // checking for null
            if (_parentWindow == null) return;

            // Getting window's DataContext
            var viewModel = (WindowViewModel)_parentWindow.DataContext;

            //Instantiating the window properties
            viewModel.CurrentPage = ApplicationPage.UploadStatus;
            viewModel.PageTitle = "Upload Status Page - Tonorp Enrollment Application";
            viewModel.IsClientLinkVisible = true;
            viewModel.IsNetworkVisible = true;
            viewModel.IsRestoreButtonVisible = true;
            viewModel.IsNewEnrollmentButtonVisible = true;
            viewModel.IsLogoutButtonVisible = true;
            viewModel.IsInfoButtonVisible = false;
            viewModel.ResizeMode = ResizeMode.CanResize;
            _parentWindow.Height = 700;
            _parentWindow.Width = 1220;
            _parentWindow.WindowState = WindowState.Maximized;

        }

        /// <summary>
        /// Logged in user activity Button Click event
        /// </summary>
        /// <param name="sender">The Caller of this event</param>
        /// <param name="e">The event arguement</param>
        private void YourActivity_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            // Checking for null
            if (_parentWindow == null) return;

            // Gettin Window's DataContext
            var viewModel = (WindowViewModel)_parentWindow.DataContext;

            //Instantiating the window properties
            viewModel.CurrentPage = ApplicationPage.YourActivity;
            viewModel.PageTitle = "Your Activity Page - Tonorp Enrollment Application";
            viewModel.IsClientLinkVisible = true;
            viewModel.IsNetworkVisible = true;
            viewModel.IsRestoreButtonVisible = true;
            viewModel.IsNewEnrollmentButtonVisible = true;
            viewModel.IsLogoutButtonVisible = true;
            viewModel.IsInfoButtonVisible = false;
            viewModel.ResizeMode = ResizeMode.CanResize;
            _parentWindow.Height = 700;
            _parentWindow.Width = 1220;
            _parentWindow.WindowState = WindowState.Maximized;

        }

        #endregion

    }
}
