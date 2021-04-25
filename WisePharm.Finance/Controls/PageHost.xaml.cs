using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        #region Dependency Properties

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get { return (ApplicationPage)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(ApplicationPage), typeof(PageHost), new UIPropertyMetadata(default(ApplicationPage), null, CurrentPagePropertyChanged));


        /// <summary>
        /// The current page view model 
        /// </summary>
        public BaseViewModel CurrentPageViewMode
        {
            get { return (BaseViewModel)GetValue(CurrentPageViewModeProperty); }
            set { SetValue(CurrentPageViewModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPageViewMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageViewModeProperty =
            DependencyProperty.Register(nameof(CurrentPageViewMode), typeof(BaseViewModel), typeof(PageHost), new UIPropertyMetadata());

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PageHost()
        {
            InitializeComponent();

            if (DesignerProperties.GetIsInDesignMode(this))
                NewPage.Content = IoC.ApplicationVM.CurrentPage.ToBasePage();
        }

        #endregion

        #region Property Event changed

        /// <summary>
        /// Called when the <see cref="CurrentPage"/> value has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="baseValue"></param>
        /// <returns></returns>
        private static object CurrentPagePropertyChanged(DependencyObject d, object value)
        {
            // Get current values 
            var currentPage = (ApplicationPage)value;
            var currentPageViewModel = d.GetValue(CurrentPageViewModeProperty);

            // Get the frames 
            var newPageframe = (d as PageHost).NewPage;
            var oldPageframe = (d as PageHost).OldPage;

            // If the current page hasn't changed
            // just update the view model
            if (newPageframe.Content is BasePage basePage && basePage.ToApplicationPage() == currentPage)
            {
                basePage.ViewModelObject = currentPageViewModel;

                return value;
            }

            // Store the current page content as the old page
            var oldPageContent = newPageframe.Content;

            // Remove current page from new page frame
            newPageframe.Content = null;

            // Move the previous page into the old page frame
            oldPageframe.Content = oldPageContent;

            //// Animate out previous page when the Loaded event fires
            //// right after this call due to moving frames
            //if (oldPageContent is BasePage oldPage)
            //{
            //    // Tell old page to animate out
            //    oldPage.ShouldAnimateOut = true;

            //    // Once it is done, remove it
            //    Task.Delay((int)(oldPage.SlideSeconds * 1000)).ContinueWith((t) =>
            //    {
            //        // Remove old page
            //        Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
            //    });
            //}

            // Set the new page content
            newPageframe.Content = currentPage.ToBasePage(currentPageViewModel);

            return value;
        }

        #endregion
    }
}
