using System.ComponentModel;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Controls;
using TonorpStandAlone.Core.ViewModel.Base;
using TonorpStandAloneWPF.Animations;

namespace TonorpStandAloneWPF.Pages
{

    /// <summary>
    /// A base page for all pages to gain base functionality
    /// </summary>
    public class BasePage : Page
    {
        #region Private Members

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private BaseViewModel _mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The animation to play when the page is first loaded
        /// </summary>
        public PageAnimationTypes PageLoadAnimation { get; set; } = PageAnimationTypes.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation to play when the page is unloaded
        /// </summary>
        public PageAnimationTypes PageUnloadAnimation { get; set; } = PageAnimationTypes.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// The view model associated with this page
        /// </summary>
        public BaseViewModel ViewModel
        {
            get { return _mViewModel; }
            set
            {
                // If nothing has changed, return
                if (_mViewModel != null && _mViewModel == value)
                    return;

                // Update the value
                _mViewModel = value;

                // Set the Data Context for this page
                DataContext = _mViewModel;
            }
        }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            // if we are animating in, hide to begin with
            if (PageLoadAnimation != PageAnimationTypes.None)
                Visibility = Visibility.Collapsed;

            // Listen out for the page loading
            Loaded += BasePage_Loaded;

            // Create a default View model
            ViewModel = new BaseViewModel();

        }

        #endregion

        #region Animation load / unload

        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            // animate the page in
            await AnimateIn();
        }

        /// <summary>
        /// Animates the page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            // Make sure we have something to do
            if (PageLoadAnimation == PageAnimationTypes.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimationTypes.SlideAndFadeInFromRight:

                    await this.SlideAndFadeInfromRightAsync(SlideSeconds);
                    break;
            }
        }

        /// <summary>
        /// Animate the page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            // Make sure we have something to do
            if (PageUnloadAnimation == PageAnimationTypes.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimationTypes.SlideAndFadeOutToLeft:

                    await this.SlideAndFadeOutToLeftAsync(SlideSeconds);
                    break;
            }
        }

        #endregion

        #region INotifyPropertyChanged interface methods implementation

        /// <summary>
        /// the event that is fired when any child property changes its property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
