using TonorpStandAlone.Core.ViewModel;

namespace TonorpStandAloneWPF.Pages
{
    /// <summary>
    /// Interaction logic for Campuses.xaml
    /// </summary>
    public partial class Campuses : BasePage
    {
        public Campuses()
        {
            InitializeComponent();
            CampusControl.ItemsSource = new CampusVm().GetCampusInfoList();
        }
    }
}