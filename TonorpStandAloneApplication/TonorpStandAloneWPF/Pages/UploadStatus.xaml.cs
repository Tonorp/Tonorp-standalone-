using System.Collections.Generic;
using TonorpStandAlone.Core.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for UploadStatus.xaml
    /// </summary>
    public partial class UploadStatus
    {
        public UploadStatus()
        {
            InitializeComponent();
            LvItems.ItemsSource = new UploadStatusViewModel().GetUploadStatusList();
        }
    }
}
