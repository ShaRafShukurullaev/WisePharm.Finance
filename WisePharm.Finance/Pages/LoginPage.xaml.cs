using System.Windows.Controls;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginPageViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public LoginPage(LoginPageViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }
    }
}
