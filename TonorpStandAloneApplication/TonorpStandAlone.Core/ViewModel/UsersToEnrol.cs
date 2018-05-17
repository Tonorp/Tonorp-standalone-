using System.Collections.Generic;

namespace TonorpStandAlone.Core.ViewModel
{
    public class UsersToEnrol
    {
        public int TotalUsers { get; set; }
        public CampusVm Campus { get; set; }
        public CampusDepartmentVm Department { get; set; }
        public CampusLevelVm Level { get; set; }
        public List<UserFingerVm> Users { get; set; }
    }
}