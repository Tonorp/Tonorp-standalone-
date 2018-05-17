using System;
using System.Security;
using System.Windows;
using TonorpStandAlone.Core.Logic;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAlone.Core.ViewModel;
using TonorpStandAlone.Core.ViewModel.Base;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : IHavePassword
    {
        #region Private members

        /// <summary>
        /// The parent window that's hosting this Page
        /// </summary>
        private Window _parentWindow;

        #endregion

        #region Constructor

        public LoginPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public SecureString SecurePassword { get; }

        #endregion

        #region Button click events

        /// <summary>
        /// Called on the ckick of login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsername.Text))
            {
                MessageBox.Show("Please enter Username and Password!");
            }
            else
            {
                //First make api call for uservm of logged in user ,then write it to LoggedInUser Directory
                // and also Use it to set Logged in User in FileInformation
                // todo: Change this code to match comment
                FileInformation fileInfo = new FileInformation();
                string errMsg;
                string path = FileInformation.GetBaseFilePath() + @"\LoggedInUser.json";

                // current user json should come from an API call. You don't
                //need a read operation to get the record.
                string jsonString = fileInfo.ReadFileToEnd(path, out errMsg);

                if (jsonString != null)
                {
                    try
                    {
                        // Setting Logged in user in the application memory
                        LoggedInUser.SetLoggedInUser(jsonString.ConvertToPoco<UserVm>());

                        // Getting the parent window
                        _parentWindow = Window.GetWindow(this);

                        // The windows DataContext
                        var viewModel = (WindowViewModel)_parentWindow?.DataContext;

                        // Change the Windows current page
                        if (viewModel != null)
                        {
                            viewModel.PageTitle = "Landing Page - Tonorp Enrollment Application";
                            viewModel.IsLogoutButtonVisible = true;
                            viewModel.IsClientLinkVisible = true;
                            viewModel.CurrentPage = ApplicationPage.LandingPage;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
        }

        #endregion
    }
}
