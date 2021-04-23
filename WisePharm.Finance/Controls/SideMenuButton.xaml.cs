using System.Windows;
using System.Windows.Controls;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for SideMenuButton.xaml
    /// </summary>
    public partial class SideMenuButton : UserControl
    {
        public SideMenuButton()
        {
            InitializeComponent();

            DataContext = this;
        }

        #region Public properties

        /// <summary>
        /// A text property that controls button <see cref="Text"/>
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(SideMenuButton));


        /// <summary>
        /// A text property that controls button <see cref="Icon"/>
        /// </summary>
        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(SideMenuButton));

        #endregion



    }
}
