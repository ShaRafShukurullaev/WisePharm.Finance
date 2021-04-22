using System;
using System.Windows.Input;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// The Icommand helper to parametrized command actions  
    ///</summarly>
    public class RelayParametrizedCommand : ICommand
    {

        #region Private Members 

        private Action<object> maction;

        #endregion

        #region Public Events 

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        ///<summarly>
        /// Default Constructor
        ///</summarly>
        public RelayParametrizedCommand(Action<object> action)
        {
            maction = action;
        }

        #endregion

        #region Commmand Methods

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            maction(parameter);
        }

        #endregion
    }
}