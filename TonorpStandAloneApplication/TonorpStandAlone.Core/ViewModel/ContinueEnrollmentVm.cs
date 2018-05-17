using System.Collections.Generic;
using TonorpStandAlone.Core.ViewModel.Base;

namespace TonorpStandAlone.Core.ViewModel
{
    public class ContinueEnrollmentVm : BaseViewModel
    {
        public int SerialNumber { get; set; }
        public string FileName { get; set; }
        public string DateCreated { get; set; }
        public string TimeCreated { get; set; }
        public string CampImgPath { get; set; }
        public string CampAlias { get; set; }
        public string CampName { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public int TotalRecord { get; set; }
        public int NoSuccUploads { get; set; }
        public int NoRemaining { get; set; }
        public int NoWithoutTemp { get; set; }

        
        /// <summary>
        /// Returns List of ContinueEnrollmentVm
        /// </summary>
        /// <returns></returns>
        public List<ContinueEnrollmentVm> GetContEnrInfo()
        {
            return new List<ContinueEnrollmentVm>
            {
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 1,
                    FileName = "ESUT-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNN",
                    CampName = "University of Nigeria Nsukka",
                    Department = "Applied Biology and Biotechnology",
                    Level = "200",
                    TotalRecord = 107,
                    NoSuccUploads = 300,
                    NoRemaining = 7,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 2,
                    FileName = "ESUT-Med-100",
                    DateCreated = "02-05-2017",
                    TimeCreated = "3hrs ago",
                    CampAlias = "ESUT",
                    CampName = "Enugu state University of Science and Technology",
                    Department = "Industrial Physics",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 3,
                    FileName = "UNN-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "5hrs 3secs ago",
                    CampAlias = "UNEC",
                    CampName = "University of Nigeria Enugu Campus",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 3011,
                    NoSuccUploads = 220,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                },
                new ContinueEnrollmentVm
                {
                    SerialNumber = 4,
                    FileName = "UNEC-Bio-200",
                    DateCreated = "02-05-2017",
                    TimeCreated = "2hrs 3secs ago",
                    CampAlias = "UNIBEN",
                    CampName = "University of Nigeria Benin",
                    Department = "Medicine and Surgery",
                    Level = "300",
                    TotalRecord = 307,
                    NoSuccUploads = 200,
                    NoRemaining = 107,
                    NoWithoutTemp = 13
                }

            };
        }
    }
}
