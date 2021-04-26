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
        /// The view model to use for the current page when the CurrentPage changes
        /// NOTE: This is not a live up-to-date view model of the current page
        ///       it is simply used to set the view model of the current page 
        ///       at the time it changes
        /// </summary>
        public BaseViewModel CurrentPageViewModel { get; set; }

        /// <summary>
        /// True if the side menu should be shown
        /// </summary>
        public bool AsosiyMenuVisible { get; set; } = false;

        /// <summary>
        /// True if the Progress dialog should be shown
        /// </summary>
        public bool ProgressDialogVisible { get; set; } = false;

        /// <summary>
        /// True if the Progress dialog should be shown
        /// </summary>
        public bool ServerReachable { get; set; } = false;

        /// <summary>
        /// Progress dialog text
        /// </summary>
        public string ProgressDialogText { get; set; }

        /// <summary>
        /// True if we should have a dimmed overlay on the window
        /// such as when a popup is visible or the window is not focused
        /// </summary>
        public bool DimmableOverlayVisible { get; set; }

        #endregion

        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page">The page to go to</param>
        /// <param name="viewModel">The view model, if any, to set explicitly to the new page</param>
        public void GoToPage(ApplicationPage page, BaseViewModel viewModel = null)
        {

            // Set the view model
            CurrentPageViewModel = viewModel;

            // See if page has changed
            var different = CurrentPage != page;

            // Set the current page
            CurrentPage = page;

            // If the page hasn't changed, fire off notification
            // So pages still update if just the view model has changed
            if (!different)
                OnPropertyChanged(nameof(CurrentPage));

            // Show side menu or not?
            // If the page is not login page show side menu
            AsosiyMenuVisible = page != ApplicationPage.Login;

        }
    }
}