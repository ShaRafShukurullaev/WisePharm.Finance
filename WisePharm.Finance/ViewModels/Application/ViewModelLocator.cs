namespace WisePharm.Finance
{
    public class ViewModelLocator
    {
        #region Public Properties

        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        public static MainMenuViewModel MainMenuViewModel => IoC.MainMenu;
        public static ApplicationViewModel ApplicationViewModel => IoC.ApplicationVM;

        #endregion
    }
}
