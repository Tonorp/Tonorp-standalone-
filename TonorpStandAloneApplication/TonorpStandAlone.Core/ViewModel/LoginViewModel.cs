using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using TonorpStandAlone.Core.Security;
using TonorpStandAlone.Core.ViewModel.Base;

namespace TonorpStandAlone.Core.ViewModel
{
    /// <summary>
    /// The view model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region public properties

        /// <summary>
        /// The Email of the User
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login commang is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Command to Login
        /// </summary>
        public ICommand LoginCommand { get; set; }


        /// <summary>
        /// The Command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Default Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            //Create Commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));

            //Create Commands
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());

        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommand(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                var email = Email;
                
                var havePassword = (IHavePassword)parameter;
                if (havePassword != null)
                {
                    //Important: Never store an unsecure password in a variable like this
                    var pass = havePassword.SecurePassword.Unsecure();
                }
            });
        }

         
        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            //TODO: Go to register page
            //var currentMainWindow = (MainWindow)Application.Current.MainWindow;
            //if (currentMainWindow != null)
            //    ((WindowViewModel)currentMainWindow.DataContext).CurrentPage = ApplicationPage.Register;

            await Task.Delay(1);
        }
    }
}
