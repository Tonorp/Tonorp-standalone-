using System;
using System.Linq;
using TonorpStandAlone.Core.ViewModel;

namespace TonorpStandAlone.Core.Logic
{
    /// <summary>
    /// Handles enrollment operation 
    /// </summary>
    public static class EnrollmentOperations
    {
        #region Public Properties

        /// <summary>
        /// The selected campus for enrollnet
        /// </summary>
        public static CampusVm SelectedCampus { get; set; }

        /// <summary>
        /// The selected Department for enrollnet
        /// </summary>
        public static CampusDepartmentVm SelectedDepartment { get; set; }

        /// <summary>
        /// The selected Level for enrollnet
        /// </summary>
        public static CampusLevelVm SelectedLevel { get; set; }

        #endregion

        #region Private class members

        /// <summary>
        /// Holds the list of Users currently being enrolled
        /// </summary>
        private static UsersToEnrol _usersToEnrol = new UsersToEnrol();

        /// <summary>
        ///  The User currently being enrolled
        /// </summary>
        private static UserFingerVm _activeUser = new UserFingerVm();

        #endregion

        #region Helper Functions

        /// <summary>
        /// Populates the Users to enrol object from and API call
        /// </summary>
        /// <returns></returns>
        public static bool SetUsersToEnrol(out string errMsg)
        {
            //Make API Call for users to enroll (temporarily reading from file)
            FileInformation fileInfo = new FileInformation();

            try
            {
                // Reading External json file for users to enrol
                var returnText = fileInfo.ReadFileToEnd(FileInformation.GetLoggedInUserFileDirectory() + @"\UsersToEnrol.json", out errMsg);

                // Converting returned User to enrol json file to POCO
                _usersToEnrol = returnText?.ConvertToPoco<UsersToEnrol>();

                return true;
            }
            catch (Exception)
            {
                errMsg = "Something went wrong! Couldn't set list of Users to enrol";
                return false;
            }

        }

        /// <summary>
        /// Returns Users to enrol
        /// </summary>
        /// <returns></returns>
        public static UsersToEnrol GetUsersToEnrol()
        {
            return _usersToEnrol;
        }

        /// <summary>
        /// Sets the User currently being enrolled
        /// </summary>
        /// <param name="regNo">The User's Reg number</param>
        /// <param name="errMsg">Output: The error message should setting active user fail</param>
        public static bool SetActiveUser(string regNo, out string errMsg)
        {
            try
            {
                _activeUser = _usersToEnrol.Users?.FirstOrDefault(x => x.User.RegNo
                .ToLower().Trim() == regNo.ToLower().Trim());

                if (_activeUser != null)
                {
                    errMsg = null;
                    return true;
                }
                errMsg = "Users with entered reg. number not found!";
                return false;
            }
            catch (Exception e)
            {
                errMsg = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Returns The User currently being enrolled
        /// </summary>
        /// <returns></returns>
        public static UserFingerVm GetActiveUser()
        {
            return _activeUser;
        }

        #endregion
    }
}
