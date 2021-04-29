namespace WisePharm.Finance
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainPageViewModel()
        {
            IoC.ApplicationVM.MainTitle = "Menu";
        }
        #endregion
    }
}
