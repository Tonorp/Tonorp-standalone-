namespace TonorpStandAlone.Core.PageDataModels
{
    /// <summary>
    /// A page of the application
    /// </summary>
    public enum ApplicationPage
    {
        /// <summary>
        /// The apps login page
        /// </summary>
        LoginPage = 0,

        /// <summary>
        /// The apps Landing page
        /// </summary>
        LandingPage = 1,

        /// <summary>
        /// page for list of Campuses
        /// </summary>
        Campuses = 2,

        /// <summary>
        /// page for New Enrollment
        /// </summary>
        NewEnrollment = 3,

        /// <summary>
        /// Overlay that covers Enrollment page, 
        /// exposing a search input filed 
        /// </summary>
        NewEnrollmentOverlay = 4,

        /// <summary>
        /// Page to Select different sets of finger thumbnails
        /// </summary>
        ChangeFingers = 5,

        /// <summary>
        /// Page that shows incomplete enrollments
        /// </summary>
        ContinueEnrollment = 6,

        /// <summary>
        /// Page that shows upload status of completed enrollment files
        /// </summary>
        UploadStatus = 7,

        /// <summary>
        /// Page to Select Type of Enrollment
        /// </summary>
        EnrollmentType = 8,

        /// <summary>
        /// Page to Select Enrollment Parameters
        /// </summary>
        NewEnrollmentParameters = 9,

        /// <summary>
        /// Page to Staff Campus
        /// </summary>
        NewEnrollmentParametersStaff = 10,

        /// <summary>
        /// Current logged in User activity
        /// </summary>
        YourActivity = 11
    }
}
