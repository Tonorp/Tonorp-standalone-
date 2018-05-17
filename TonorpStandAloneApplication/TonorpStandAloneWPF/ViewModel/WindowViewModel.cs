using System.Windows;
using System.Windows.Input;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAlone.Core.ViewModel.Base;
using TonorpStandAloneWPF.Pages.Dialogs;

namespace TonorpStandAloneWPF.ViewModel
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region  Private members
        /// <summary>
        /// The window this view model controls
        /// </summary>
        private readonly Window _mWindow;
        
        #endregion

        #region public properties
        /// <summary>
        /// The mininmum width the window can go
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 800;

        /// <summary>
        /// The mininmum Height the window can go
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 400;

        /// <summary>
        /// The Padding of the inner content of the main window
        /// taking into account the outerMargin
        /// </summary>
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);

        /// <summary>
        /// The margin around the window to allow for drop shadow
        /// (Checking windows maximized state)
        /// </summary>
        private int _outerMarginSize;

        public int OuterMarginSize
        {
            get
            {
                return _mWindow.WindowState == WindowState.Maximized ? 0 : 10;
            }
            set
            {
                if (value == _outerMarginSize) return;
                _outerMarginSize = value;

                // This raises the PropertyChanged event to let the UI update
                OnPropertyChanged(nameof(OuterMarginSize));
            }
        }

        /// <summary>
        /// The thickness of the OuterMargin based on window maximized state
        /// </summary>
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);


        /// <summary>
        /// The title/caption of the window
        /// </summary>
        private string _pageTitle = "Welcome to Tonorp Enrollment Application";

        public string PageTitle
        {
            get { return _pageTitle; }
            set
            {
                if (value == _pageTitle)
                    return;
                _pageTitle = value;

                // This raises the PropertyChanged event to let the UI know to update
                OnPropertyChanged(nameof(PageTitle));
            }
        }

        /// <summary>
        /// The height of the title/caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 42;

        /// <summary>
        /// Determines if Windows restore button is Visible or not
        /// </summary>
        private bool _isRestoreButtonVisible = true;

        public bool IsRestoreButtonVisible
        {
            get { return _isRestoreButtonVisible; }
            set
            {
                if (value == _isRestoreButtonVisible) return;
                _isRestoreButtonVisible = value;

                // This raises the PropertyChanged event to show or hide Window Restore button
                OnPropertyChanged(nameof(IsRestoreButtonVisible));
            }
        }

        /// <summary>
        /// Determines if Windows Logout button is Visible or not
        /// </summary>
        private bool _isLogoutButtonVisible;

        public bool IsLogoutButtonVisible
        {
            get { return _isLogoutButtonVisible; }
            set
            {
                if (value == _isLogoutButtonVisible) return;
                _isLogoutButtonVisible = value;

                // This raises the PropertyChanged event to show or hide Window Logout button
                OnPropertyChanged(nameof(IsLogoutButtonVisible));
            }
        }

        /// <summary>
        /// Determines if Windows New Enrollment button is Visible or not
        /// </summary>
        private bool _isNewEnrollmentButtonVisible;

        public bool IsNewEnrollmentButtonVisible
        {
            get { return _isNewEnrollmentButtonVisible; }
            set
            {
                if (value == _isNewEnrollmentButtonVisible) return;
                _isNewEnrollmentButtonVisible = value;

                // This raises the PropertyChanged event to show or hide Window New Enrollment button
                OnPropertyChanged(nameof(IsNewEnrollmentButtonVisible));
            }
        }

        /// <summary>
        /// Determines if Network availability status is Visible or not
        /// </summary>
        private bool _isNetworkVisible;

        public bool IsNetworkVisible
        {
            get { return _isNetworkVisible; }
            set
            {
                if (value == _isNetworkVisible) return;
                _isNetworkVisible = value;

                // This raises the PropertyChanged event to show or hide Network availability status
                OnPropertyChanged(nameof(IsNetworkVisible));
            }
        }

        /// <summary>
        /// Determines if Client Hyperlink is Visible or not
        /// </summary>
        private bool _isClientLinkVisible;

        public bool IsClientLinkVisible
        {
            get { return _isClientLinkVisible; }
            set
            {
                if (value == _isClientLinkVisible) return;
                _isClientLinkVisible = value;

                // This raises the PropertyChanged event to show or hide Client Hyperlink
                OnPropertyChanged(nameof(IsClientLinkVisible));
            }
        }

        /// <summary>
        /// Determines if Windows New Info button is Visible or not
        /// </summary>
        private bool _isInfoButtonVisible;

        public bool IsInfoButtonVisible
        {
            get { return _isInfoButtonVisible; }
            set
            {
                if (value == _isInfoButtonVisible) return;
                _isInfoButtonVisible = value;

                // This raises the PropertyChanged event to show or hide Window Info button
                OnPropertyChanged(nameof(IsInfoButtonVisible));
            }
        }

        /// <summary>
        /// Determines if Overlay on this Window should be Visible or not
        /// </summary>
        private bool _isWindowOverlayVisible;

        public bool IsWindowOverlayVisible
        {
            get { return _isWindowOverlayVisible; }
            set
            {
                if (value == _isWindowOverlayVisible) return;
                _isWindowOverlayVisible = value;

                // This raises the PropertyChanged event to let the UI know to update
                OnPropertyChanged(nameof(IsWindowOverlayVisible));
            }
        }

        /// <summary>
        /// The Current page of the application
        /// </summary>

        private ApplicationPage _currentPage = ApplicationPage.LoginPage;

        public ApplicationPage CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (value == _currentPage)
                    return;
                _currentPage = value;

                // This raises the PropertyChanged event to let the UI know to update
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        /// <summary>
        /// The Current page of the application
        /// </summary>

        private WindowStartupLocation _windowStartLoc = WindowStartupLocation.CenterScreen;

        public WindowStartupLocation WindowStartLoc
        {
            get { return _windowStartLoc; }
            set
            {
                if (value == _windowStartLoc)
                    return;
                _windowStartLoc = value;

                // This raises the PropertyChanged event for window start location
                OnPropertyChanged(nameof(WindowStartLoc));
            }
        }

        /// <summary>
        /// The Resize mode of the window indicating whether the window can be 
        /// resized or not
        /// </summary>

        private ResizeMode _resizeMode = ResizeMode.CanResize;

        public ResizeMode ResizeMode
        {
            get { return _resizeMode; }
            set
            {
                if (value == _resizeMode)
                    return;
                _resizeMode = value;

                // This raises the PropertyChanged event for window resize Property
                OnPropertyChanged(nameof(ResizeMode));
            }
        }

        #endregion

        #region Commands
        /// <summary>
        /// Command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// Command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// Command to Close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// Command to show the System menu of the window
        /// </summary>
        public ICommand MenuCommand { get; set; }

        /// <summary>
        /// Logs out user from current page and leads to Login page
        /// </summary>
        public ICommand LogoutCommand { get; set; }

        /// <summary>
        /// Opens Dialog window for Enrollment Type
        /// </summary>
        public ICommand NewEnrollmentCommand { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            _mWindow = window;
            _mWindow.Height = window.Height;
            _mWindow.Width = window.Width;
            _mWindow.WindowStartupLocation = window.WindowStartupLocation;

            //Listening out for window resizing
            _mWindow.StateChanged += (sender, e) =>
            {
                //Fire off event for all properties affected by window resize
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
            };

            //Create Commands for window chrome buttons
            MinimizeCommand = new RelayCommand(() => _mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => _mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(CloseWindow);
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(_mWindow, GetMousePosition()));
            LogoutCommand = new RelayCommand(Logout);
            NewEnrollmentCommand = new RelayCommand(NewEnrollment);
        }

        #endregion

        #region Private Helpers functions

        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            //Position of the mouse relative to the Window
            var position = Mouse.GetPosition(_mWindow);

            //Add the window positon so it's a "ToScreen"
            return new Point(position.X + _mWindow.Left, position.Y + _mWindow.Top);
        }

        /// <summary>
        /// Logouts out User from current page and takes User to Login page
        /// </summary>
        private void Logout()
        {
            // Instance of WindowViewModel for the current window
            var windowViewModel = _mWindow.DataContext as WindowViewModel;

            if (windowViewModel != null)
            {
                // Initializing window properties
                windowViewModel.PageTitle = "Welcome to Tonorp Enrollment Application";
                _mWindow.Width = 1020;
                _mWindow.Height = 550;
                _mWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                windowViewModel.IsRestoreButtonVisible = true;
                windowViewModel.IsLogoutButtonVisible = false;
                windowViewModel.IsNewEnrollmentButtonVisible = false;
                windowViewModel.IsClientLinkVisible = false;
                windowViewModel.IsInfoButtonVisible = false;
                windowViewModel.IsNetworkVisible = false;
                windowViewModel.ResizeMode = ResizeMode.NoResize;
                windowViewModel.CurrentPage = ApplicationPage.LoginPage;
            }

        }

        /// <summary>
        /// Closes the activity in the current page and navigates 
        /// user to Landing page
        /// </summary>
        private void CloseWindow()
        {
            // Creating an instance of window view Model for the new page 
            // to be loaded
            var viewModel = (WindowViewModel)_mWindow.DataContext;

            if (viewModel.CurrentPage == ApplicationPage.LandingPage ||
                viewModel.CurrentPage == ApplicationPage.LoginPage ||
                viewModel.CurrentPage == ApplicationPage.NewEnrollmentParameters ||
                viewModel.CurrentPage == ApplicationPage.NewEnrollmentParametersStaff ||
                viewModel.CurrentPage == ApplicationPage.EnrollmentType ||
                viewModel.CurrentPage == ApplicationPage.ChangeFingers)
                _mWindow.Close();

            // Initializing window properties
            viewModel.IsWindowOverlayVisible = false;
            viewModel.PageTitle = "Landing page - Tonorp Enrollment Application";
            viewModel.WindowStartLoc = WindowStartupLocation.CenterScreen;
            viewModel.IsInfoButtonVisible = false;
            viewModel.IsNewEnrollmentButtonVisible = false;
            viewModel.IsRestoreButtonVisible = true;
            viewModel.IsNetworkVisible = false;
            viewModel.ResizeMode = ResizeMode.NoResize;
            _mWindow.Height = 550;
            _mWindow.Width = 1020;
            _mWindow.WindowState = WindowState.Maximized;
            viewModel.CurrentPage = ApplicationPage.LandingPage;
        }

        /// <summary>
        /// Opens Enrollment Type Dialog
        /// </summary>
        private void NewEnrollment()
        {
            if (_mWindow != null)
            {
                //Instance of BaseWindowDialog to host NewEnrollment Page
                BaseWindowDialog window = new BaseWindowDialog();

                //Instantiating the window properties
                window.ViewModel.CurrentPage = ApplicationPage.EnrollmentType;
                window.ViewModel.PageTitle = "SELECT ENROLLMENT TYPE";
                window.Height = 350;
                window.Width = 620;

                // Setting the overlay of parent window to true
                ((WindowViewModel)_mWindow.DataContext).IsWindowOverlayVisible = true;

                // Removing Parent window overlay on closing of this window
                window.Closing += (o, args) => ((WindowViewModel)_mWindow.DataContext).IsWindowOverlayVisible = false;

                //Show Enrollment Type Window
                window.ShowDialog();
            }
        }

        #endregion

    }
}
