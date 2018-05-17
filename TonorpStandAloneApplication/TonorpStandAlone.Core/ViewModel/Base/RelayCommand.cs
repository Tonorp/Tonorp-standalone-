using System;
using System.Windows.Input;

namespace TonorpStandAlone.Core.ViewModel.Base
{
    /// <summary>
    /// A basic command that runs an Action
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private members
        /// <summary>
        /// The action to run
        /// </summary>
        private readonly Action _mAction;
        #endregion

        #region public Events
        /// <summary>
        /// The event that gets fired when the <see cref="CanExecute(object)"/> has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        #endregion

        #region Custructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            _mAction = action;
        }
        #endregion

        #region Command methods
        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }


        /// <summary>
        /// Execute the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _mAction();
        }
        #endregion
    }
}
