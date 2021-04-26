namespace WisePharm.Finance
{
    /// <summary>
    /// Locator view model from the IoC for use in binding in xaml file
    /// </summary>
    public class ViewModelLocator
    {
        #region Public Properties

        /// <summary>
        /// Singleton instance of view locator 
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// Application view model locator
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoC.ApplicationVM;

        /// <summary>
        /// Main Menu view model locator 
        /// </summary>
        public static MainMenuViewModel MainMenuViewModel => IoC.MainMenu;

        #endregion
    }
}
