using System.Windows;
using System.Windows.Input;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// The ViewModel for MainWindow
    ///</summarly>
    public class MainWindowViewModel : BaseViewModel
    {
        #region Private Members 

        /// <summary>
        /// Main window 
        /// </summary>
        private Window mwindow;

        #endregion

        #region Constructor

        ///<summarly>
        /// Default Constructor
        ///</summarly>
        public MainWindowViewModel(Window window)
        {
            mwindow = window;
        }

        #endregion
    }
}