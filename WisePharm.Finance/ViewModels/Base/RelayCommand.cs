using System;
using System.Windows.Input;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// The Defalut ICommand to help Command actions 
    ///</summarly>
    public class RelayCommand : ICommand
    {
        #region Private Members

        private Action maction;

        #endregion

        #region Public Events 

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        ///<summarly>
        /// Default Constructor
        ///</summarly>
        public RelayCommand(Action action)
        {
            maction = action;
        }

        #endregion

        #region Command  Methods

        public bool CanExecute(object parameter)
        {
            return true; 
        }

        public void Execute(object parameter)
        {
            maction();
        }

        #endregion
    }
}