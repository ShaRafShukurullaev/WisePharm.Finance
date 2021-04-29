using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// Helpers to animate framework elements in specific ways
    ///</summarly>
    public static class FrameworkElementAnimatons
    {
        #region Slide and Fade In/Out

        /// <summary>
        /// Slide and Fade an element in
        /// </summary>
        /// <param name="element"></param>
        /// <param name="direction"></param>
        /// <param name="firstLoad"></param>
        /// <param name="seconds"></param>
        /// <param name="keepMargin"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeInAsync(this FrameworkElement element, AnimationSlideDirection direction, bool firstLoad, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            // Create the storyboard 
            var sb = new Storyboard();

            // Slide in the correct direction
            switch (direction)
            {
                case AnimationSlideDirection.Left:
                    sb.AddSlideFromLeft(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                case AnimationSlideDirection.Right:
                    sb.AddSlideFromRight(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                case AnimationSlideDirection.Top:
                    sb.AddSlideFromTop(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
                case AnimationSlideDirection.Bottom:
                    sb.AddSlideFromBottom(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
            }

            // Add fade in animation 
            sb.AddFadeIn(seconds);

            // Start animationg
            sb.Begin(element);

            // Make page visible only if we are animating or its the first load 
            if (seconds != 0 || firstLoad)
                element.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));

        }


        /// <summary>
        /// Slide and Fade an element out
        /// </summary>
        /// <param name="element"></param>
        /// <param name="direction"></param>
        /// <param name="firstLoad"></param>
        /// <param name="seconds"></param>
        /// <param name="keepMargin"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutAsync(this FrameworkElement element, AnimationSlideDirection direction, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            // Create the storyboard 
            var sb = new Storyboard();

            // Slide in the correct direction
            switch (direction)
            {
                case AnimationSlideDirection.Left:
                    sb.AddSlideToLeft(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                case AnimationSlideDirection.Right:
                    sb.AddSlideToRight(seconds, size == 0 ? element.ActualWidth : size, keepMargin: keepMargin);
                    break;
                case AnimationSlideDirection.Top:
                    sb.AddSlideToTop(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
                case AnimationSlideDirection.Bottom:
                    sb.AddSlideToBottom(seconds, size == 0 ? element.ActualHeight : size, keepMargin: keepMargin);
                    break;
            }

            // Add fade in animation 
            sb.AddFadeIn(seconds);

            // Start animationg
            sb.Begin(element);

            // Make page visible only if we are animating or its the first load 
            if (seconds != 0)
                element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Make element invisible
            if (element.Opacity == 0)
                element.Visibility = Visibility.Hidden;

        }


        #endregion

        #region Fade In/Out

        /// <summary>
        /// Fades an element in 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="firstLoad"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task FadeInAsync(this FrameworkElement element, bool firstLoad, float seconds = 0.3f)
        {
            // Create the storyboard 
            var sb = new Storyboard();

            // Add fade in animaton 
            sb.AddFadeIn(seconds);

            // Start begin 
            sb.Begin(element);

            // Make page visible only if we are animating or its the first load
            if (seconds != 0 || firstLoad)
                element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Fades out an element
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="firstLoad">Indicates if this is the first load</param>
        /// <returns></returns>
        public static async Task FadeOutAsync(this FrameworkElement element, float seconds = 0.3f)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible only if we are animating or its the first load
            if (seconds != 0)
                element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Fully hide the element
            element.Visibility = Visibility.Collapsed;
        }

        #endregion
    }
}