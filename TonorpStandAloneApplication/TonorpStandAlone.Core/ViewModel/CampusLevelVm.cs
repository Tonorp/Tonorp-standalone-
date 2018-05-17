using System.Collections.Generic;

namespace TonorpStandAlone.Core.ViewModel
{
    public class CampusLevelVm
    {
        public long? CampusLevelId { get; set; }
        public string Level { get; set; }
        //public object Obj => this;

        /// <summary>
        /// Returns List of Campus Levels
        /// </summary>
        /// <returns></returns>
        public List<CampusLevelVm> GetCampusLevels()
        {
            return new List<CampusLevelVm>
            {
                new CampusLevelVm {CampusLevelId = 1, Level = "100" },
                new CampusLevelVm {CampusLevelId = 2, Level = "200" },
                new CampusLevelVm {CampusLevelId = 3, Level = "300" },
                new CampusLevelVm {CampusLevelId = 4, Level = "400" },
                new CampusLevelVm {CampusLevelId = 5, Level = "500" },
                new CampusLevelVm {CampusLevelId = 6, Level = "600" },
            };
        }
    }
}