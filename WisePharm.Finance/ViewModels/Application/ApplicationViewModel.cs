namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// The Application viewmode for this application this view model visibles all classes  
    ///</summarly>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public Properties 

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.MainPage;

        /// <summary>
        /// The current page view model 
        /// </summary>
        public BaseViewModel CurrentPageViewModel { get; set; }

        /// <summary>
        /// True if the side menu should be shown
        /// </summary>
        public bool SideMenuVisible { get; set; }

        /// <summary>
        /// True if the Progress dialog should be shown
        /// </summary>
        public bool ProgressDialogVisible { get; set; }

        /// <summary>
        /// Progress dialog text
        /// </summary>
        public string ProgressDialogText { get; set; }

        /// <summary>
        /// True if we should have a dimmed overlay on the window
        /// such as when a popup is visible or the window is not focused
        /// </summary>
        public bool DimmerOverlayVisible { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// The method that controls page connection
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel"></param>
        public void GotoPage(ApplicationPage page, BaseViewModel viewModel = null)
        {
            CurrentPageViewModel = viewModel;

            var different = CurrentPage != page;

            CurrentPage = page;

            if (!different)
                OnPropertyChanged(nameof(CurrentPage));

            SideMenuVisible = page != ApplicationPage.Login;
        }


        #endregion
    }
}