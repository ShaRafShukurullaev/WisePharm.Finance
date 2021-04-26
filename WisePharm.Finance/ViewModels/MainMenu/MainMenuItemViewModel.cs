using System.Windows.Input;

namespace WisePharm.Finance
{
    public class MainMenuItemViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The property that controls button text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The property that controls button icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The property that controls is button selected or not
        /// </summary>
        public bool IsSelected { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command that works when button is clicked
        /// </summary>
        public ICommand ClickCommand { get; set; }

        #endregion 
    }
}
