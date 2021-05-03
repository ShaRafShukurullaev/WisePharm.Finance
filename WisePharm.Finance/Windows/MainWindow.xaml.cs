using System.Windows;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel(this);
        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            IoC.ApplicationVM.DimmableOverlayVisible = false;
        }

        private void Window_Deactivated(object sender, System.EventArgs e)
        {
            IoC.ApplicationVM.DimmableOverlayVisible = true;
        }
    }
}