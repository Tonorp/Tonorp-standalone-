using TonorpStandAlone.Core.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for YourActivity.xaml
    /// </summary>
    public partial class YourActivity
    {
        public YourActivity()
        {
            InitializeComponent();
            UserActivityItemControl.ItemsSource = new UserActivityModel().GetUserActivityList();
        }
    }
}
