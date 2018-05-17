using TonorpStandAlone.Core.ViewModel;

namespace TonorpStandAlone.Core.Logic
{
    public static class LoggedInUser
    {
        /// <summary>
        /// Instance of Logged-in User
        /// </summary>
        private static UserVm _loggedInUser;

        /// <summary>
        /// Sets Logged in user's object
        /// </summary>
        /// <param name="user"></param>
        public static void SetLoggedInUser(UserVm user)
        {
            _loggedInUser = new UserVm()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                OtherName = user.OtherName,
                RegNo = user.RegNo,
                DateAdded = user.DateAdded,
                Department = user.Department,
                Image = user.Image,
                UserType = user.UserType,
                UserTypeName = user.UserTypeName,
                InputOption = user.InputOption
            };
        }

        /// <summary>
        /// Returns Logged in User
        /// </summary>
        /// <returns></returns>
        public static UserVm GetLoggedInUser()
        {
            return _loggedInUser;
        }
    }
}
