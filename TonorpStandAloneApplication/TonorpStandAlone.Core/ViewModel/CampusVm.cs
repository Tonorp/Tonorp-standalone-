using System;
using System.Collections.Generic;

namespace TonorpStandAlone.Core.ViewModel
{
    public class CampusVm
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public DateTime DateAdded { get; set; }
        public string Alias { get; set; }
        public string Initial { get; set; }
        //public object Obj => this;

        /// <summary>
        /// Returns List of Campus Info
        /// </summary>
        /// <returns></returns>
        public List<CampusVm> GetCampusInfoList()
        {
            return new List<CampusVm>
            {
                new CampusVm
                {
                    Alias = "ESUT",
                    Name = "Enugu State University of Science and Technology",
                    Address = "Number 16 Umueze Road, Off Agbani Disc, Enugu State",
                    Initial = "ESU"
                },
                new CampusVm
                {
                    Alias = "IMT",
                    Name = "Institute of Management and Technology",
                    Address = "Nkpokiti, Afia nine bus stop, Enugu State",
                    Initial = "IMT"
                },
                new CampusVm
                {
                    Alias = "UNIBEN",
                    Name = "University of Nigeria Benin",
                    Address = "New Benin, Benin City, Edo State",
                    Initial = "UNI"
                },
                new CampusVm
                {
                    Alias = "UNN",
                    Name = "University of Nigeria Nsukka",
                    Address = "Edozie Roundabout, Kenyatta Close, Enugu State",
                    Initial = "UNN"
                },
                new CampusVm
                {
                    Alias = "COUNI",
                    Name = "Coal City University",
                    Address = "Edozie Roundabout, Kenyatta Close, Enugu State",
                    Initial = "UNN"
                },
                new CampusVm
                {
                    Alias = "UNICAL",
                    Name = "University of Calabar",
                    Address = "Edozie Roundabout, Kenyatta Close, Enugu State",
                    Initial = "UNN"
                }
            };
        }
    }
}
