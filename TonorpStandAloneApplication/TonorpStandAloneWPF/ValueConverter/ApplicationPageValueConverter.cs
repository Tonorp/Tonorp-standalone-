using System;
using System.Diagnostics;
using System.Globalization;
using TonorpStandAlone.Core.PageDataModels;
using TonorpStandAloneWPF.Pages;

namespace TonorpStandAloneWPF.ValueConverter
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual View/Page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            if (value != null)
                switch ((ApplicationPage)value)
                {
                    case ApplicationPage.LoginPage:
                        return new LoginPage();

                    case ApplicationPage.LandingPage:
                        return new LandingPage();

                    case ApplicationPage.Campuses:
                        return new Campuses();

                    case ApplicationPage.NewEnrollment:
                        return new NewEnrollment();

                    case ApplicationPage.NewEnrollmentOverlay:
                        return new NewEnrollmentOverlay();

                    case ApplicationPage.ChangeFingers:
                        return new ChangeFingers();

                    case ApplicationPage.ContinueEnrollment:
                        return new ContinueEnrollment();

                    case ApplicationPage.UploadStatus:
                        return new UploadStatus();

                    case ApplicationPage.EnrollmentType:
                        return new EnrollmentType();

                    case ApplicationPage.NewEnrollmentParameters:
                        return new NewEnrollmentParameters();

                    case ApplicationPage.NewEnrollmentParametersStaff:
                        return new NewEnrollmentParametersStaff();

                    case ApplicationPage.YourActivity:
                        return new YourActivity();

                    default:
                        Debugger.Break();
                        return null;
                }
            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
