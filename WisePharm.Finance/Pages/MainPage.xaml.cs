using System.Windows.Controls;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : BasePage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(MainPageViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }

        private void DataGrid1_LoadingRow(object sender, DataGridRowEventArgs e)
        {

        }
    }
}
