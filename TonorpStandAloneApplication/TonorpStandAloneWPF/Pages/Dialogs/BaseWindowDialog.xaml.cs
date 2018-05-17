using System.Windows;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF.Pages.Dialogs
{
    /// <summary>
    /// Interaction logic for BaseWindowDialog.xaml
    /// </summary>
    public partial class BaseWindowDialog : Window
    {
        #region Public properties

        /// <summary>
        /// The ViewModel this window depends on
        /// </summary>
        public WindowViewModel ViewModel => (WindowViewModel)DataContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BaseWindowDialog()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);

        }

        #endregion
    }
}
