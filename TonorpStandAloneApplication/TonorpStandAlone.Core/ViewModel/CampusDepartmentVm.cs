using System.Collections.Generic;

namespace TonorpStandAlone.Core.ViewModel
{
    /// <summary>
    /// CampusDepartment object
    /// </summary>
    public class CampusDepartmentVm
    {
        public long? CampusDepartmentId { get; set; }
        public string DeptName { get; set; }
        public string DeptAlias { get; set; }
        //public object Obj => this;

        /// <summary>
        /// Returns List of Campus Departments
        /// </summary>
        /// <returns></returns>
        public List<CampusDepartmentVm> GetCampusDepartments()
        {
            return new List<CampusDepartmentVm>
            {
                new CampusDepartmentVm
                {
                    CampusDepartmentId = 2,
                    DeptName = "Applied Biology and Biotechnology",
                    DeptAlias = "ABB"
                },
                new CampusDepartmentVm
                {
                    CampusDepartmentId = 3,
                    DeptName = "Medicine and Surgery",
                    DeptAlias = "MEDSURG"
                },
                new CampusDepartmentVm
                {
                    CampusDepartmentId = 4,
                    DeptName = "Software Engineering ",
                    DeptAlias = "SOFT"
                }
            };
        }
    }
}