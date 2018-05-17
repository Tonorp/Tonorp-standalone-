using System;
using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using TonorpStandAloneWPF.ViewModel;

namespace TonorpStandAloneWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public properties

        /// <summary>
        /// The View model this window depends on
        /// </summary>
        public WindowViewModel ViewModel => (WindowViewModel)DataContext;

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);

            // Creating a timer to check for network availability every one second
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }
        #endregion

        #region Helper functions

        /// <summary>
        /// Timer tick event to check network availability status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NtwAvailableColor.Color = Colors.LimeGreen;
                NtwAvailableText.Text = "Connected";
            }
            else
            {
                NtwAvailableColor.Color = Colors.Red;
                NtwAvailableText.Text = "Offline";
            }
        }

        #endregion

    }

}
