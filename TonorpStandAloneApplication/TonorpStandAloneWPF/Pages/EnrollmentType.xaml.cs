using System;
using System.Windows;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for EnrollmentType.xaml
    /// </summary>
    public partial class EnrollmentType
    {
        /// <summary>
        /// The parent window that's hosting this Page
        /// </summary>
        private Window _parentWindow;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnrollmentType()
        {
            InitializeComponent();
        }

        #region

        /// <summary>
        /// Action performed when Staff enrollment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StaffEnrollment_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            if (_parentWindow == null)
                return;

            // Instance of window viewModel
            var viewModel = (WindowViewModel)_parentWindow.DataContext;

            // Populating the window properties
            viewModel.PageTitle = "SELECT STAFF CAMPUS";
            viewModel.CurrentPage = ApplicationPage.NewEnrollmentParametersStaff;
        }

        /// <summary>
        /// Action performed when Student enrollment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StudentEnrollment_Clicked(object sender, RoutedEventArgs e)
        {
            // Getting the parent window
            _parentWindow = Window.GetWindow(this);

            if (_parentWindow == null)
                return;

            // Instance of window viewModel
            var viewModel = (WindowViewModel) _parentWindow.DataContext;

            // Populating the window properties
            viewModel.PageTitle = "SELECT ENROLLMENT PARAMETERS";
            viewModel.CurrentPage = ApplicationPage.NewEnrollmentParameters;
        }
        
        #endregion

        #region Helper Methods


        /// <summary>
        /// Gets the Window with the supplied title
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

        ///// <summary>
        ///// Switch Current Page to Landing Page
        ///// </summary>
        //private void InitLanding()
        //{
        //    ((WindowViewModel)_parentWindow.DataContext).IsWindowOverlayVisible = false;
        //    var landing = new MainWindow();
        //    landing.ViewModel.CurrentPage = ApplicationPage.LandingPage;
        //    landing.ViewModel.PageTitle = "Landing page - Tonorp Attendance";
        //    landing.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        //    landing.Height = 650;
        //    landing.Width = 1220;
        //    landing.Show();
        //}

        #endregion
    }
}
