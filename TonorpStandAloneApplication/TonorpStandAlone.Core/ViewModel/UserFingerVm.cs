using System.Collections.Generic;

namespace TonorpStandAlone.Core.ViewModel
{
    public class UserFingerVm
    {
        public UserVm User { get; set; }
        public IEnumerable<FingerVmList> Fingers { get; set; }
    }
}