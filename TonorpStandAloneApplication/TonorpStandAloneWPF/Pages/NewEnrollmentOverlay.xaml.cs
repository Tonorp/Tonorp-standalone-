using System.Windows;
using System.Windows.Input;
using TonorpStandAlone.Core.Logic;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for NewEnrollmentOverlay.xaml
    /// </summary>
    public partial class NewEnrollmentOverlay
    {
        #region Private Properties
        /// <summary>
        /// The parent window that's hosting this Page
        /// </summary>
        private Window _parentWindow;

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NewEnrollmentOverlay()
        {
            InitializeComponent();

            // User search input field KeyUp event
            TxtSearchUser.KeyUp += SearchInput_KeyUp;
        }

        #endregion

        #region Button events

        /// <summary>
        /// Button Click event to fetch User with entered reg. number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SearchButton_Clicked(object sender, RoutedEventArgs e)
        {
            SetActiveUserByRegNo();
        }

        /// <summary>
        /// Called on Search input keyUP event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                SetActiveUserByRegNo();
        }

        #endregion

        #region Helper functions

        /// <summary>
        /// Searches User to enrol by reg number typed in the Search input field
        /// </summary>
        private void SetActiveUserByRegNo()
        {
            // Checking to make sure search input field is not empty
            if (string.IsNullOrWhiteSpace(TxtSearchUser.Text))
            {
                MessageBox.Show("Please enter user's Reg. Number in the search field");
            }
            else
            {
                // Variable to hold error message if any
                string errMsg;

                if (EnrollmentOperations.SetActiveUser(TxtSearchUser.Text, out errMsg))
                {
                    // Getting the parent window
                    _parentWindow = Window.GetWindow(this);

                    // Change the Windows current page
                    if (_parentWindow != null)
                        ((WindowViewModel)_parentWindow.DataContext).CurrentPage = ApplicationPage.NewEnrollment;
                }
                else
                {
                    MessageBox.Show(errMsg);
                }
            }
        }

        #endregion
    }



}
