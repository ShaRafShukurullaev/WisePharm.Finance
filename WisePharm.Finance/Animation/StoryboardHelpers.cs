using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// Animation helpers for <see cref="StoryBoard"/>
    ///</summarly>
    public static class StoryboardHelpers
    {

        #region Sliding To/From Left 

        /// <summary>
        /// Adds a slide from left animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide to left animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Sliding To/Form Right

        /// <summary>
        /// Adds a slide from right animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide from right animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Sliding To/From Top

        /// <summary>
        /// Adds a slide from Top animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideFromTop(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, -offset, 0, keepMargin ? offset : 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide from Top animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideToTop(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, -offset, 0, keepMargin ? offset : 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Sliding To/From Bottom 

        /// <summary>
        /// Adds a slide from Bottom animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideFromBottom(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, keepMargin ? offset : 0, 0, -offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide To Bottom animaton to the storyboard 
        /// </summary>
        /// <param name="storyboard"> The storyboard to add the animaton to </param>
        /// <param name="seconds">the time the animation will take </param>
        /// <param name="offset">The distance to the left to start from </param>
        /// <param name="decelerationRatio">the rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same with during animation </param>
        public static void AddSlideToBottom(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // Create the margin animate from right 
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, keepMargin ? offset : 0, 0, -offset),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Fade In/Out 

        /// <summary>
        /// Adds a fade in animation to the stroeyboard 
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="seconds"></param>
        /// <param name="from"></param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds, bool from = false)
        {

            // Create the margin animation from right 
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                To = 1,
            };

            // Animation from if requested 
            if (from)
                animation.From = 0;

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard 
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a fade out animation to the stroeyboard 
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="seconds"></param>
        /// <param name="from"></param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {

            // Create the margin animation from right 
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                To = 0,
            };

            // Set the target property name 
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard 
            storyboard.Children.Add(animation);
        }

        #endregion

    }
}