using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for LogoSVG.xaml
    /// </summary>
    public partial class DollarSVG : UserControl
    {
        public DollarSVG()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dependency property to change fill color 
        /// </summary>
        public Brush BGColor
        {
            get { return (Brush)GetValue(BGColorProperty); }
            set { SetValue(BGColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BGColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BGColorProperty =
            DependencyProperty.Register("BGColor", typeof(Brush), typeof(DollarSVG));

    }
}
