using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WisePharm.Finance
{
    public class MainMenuViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The variable that stores current time
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Login view model 
        /// </summary>
        public LoginPageViewModel LoginViewModel { get; set; }

        /// <summary>
        /// The variable that stores index of 
        /// </summary>
        public int SelectedIndex { get; set; } = 0;

        public ObservableCollection<MainMenuItemViewModel> items;
        /// <summary>
        /// The menu button list items for the list
        /// </summary>  
        public ObservableCollection<MainMenuItemViewModel> Items
        {
            get
            {
                items = new ObservableCollection<MainMenuItemViewModel>();

                if (LoginViewModel == null)
                    return null;

                // Asosiy menu button index berilmoqda
                IndexMain = items.Count;

                // Menuga Asosiy oyna buttonini qoshish
                items.Add(new MainMenuItemViewModel
                {
                    Text = "Asosiy oyna",
                    Icon = "\uf015",
                    IsSelected = true,
                    ClickCommand = new RelayParametrizedCommand(async (parameter) =>
                       await GotoPage(ApplicationPage.MainPage))
                });

                return items;
            }

            set
            {
                if (items != value)
                    items = value;
            }
        }

        #endregion

        #region Public MenuButton index variables

        /// <summary>
        /// The main button index
        /// </summary>
        public int IndexMain { get; set; }

        /// <summary>
        /// The Buy button index
        /// </summary>
        public int IndexBuy { get; set; }

        /// <summary>
        /// The SaleButton index
        /// </summary>
        public int IndexSale { get; set; }

        /// <summary>
        /// The CashBox button index
        /// </summary>
        public int IndexCashBox { get; set; }

        /// <summary>
        /// The return button index
        /// </summary>
        public int IndexReturn { get; set; }

        /// <summary>
        /// The reports button index
        /// </summary>
        public int IndexReports { get; set; }

        /// <summary>
        /// The service button index
        /// </summary>
        public int IndexService { get; set; }

        #endregion

        public async Task GotoPage(ApplicationPage page)
        {
            string title;
            int index = 0;
            switch (page)
            {
                case ApplicationPage.MainPage:
                    //title = "Asosiy hisobotlar yuklanmoqda...";
                    index = IndexMain;
                    break;
            }


            // Yangi oynaga otilmoqda
            await RunCommandAsync(() => IoC.ApplicationVM.ProgressDialogVisible, async () =>
            {
                if (page == ApplicationPage.MainPage)
                {
                    // Yangi oynaga transport royhatini berib yuborilmoqda
                    IoC.ApplicationVM.GoToPage(page, new MainPageViewModel());

                }

                // Menudagi tanlangan buttonni tanlanmagan 
                items[SelectedIndex].IsSelected = false;

                // Tanlangan indexni belgilash
                SelectedIndex = index;

                // Select this menu button
                items[index].IsSelected = true;

            });

        }

        public DispatcherTimer _timer;

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainMenuViewModel()
        {
            _timer = new DispatcherTimer(DispatcherPriority.Render);
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (sender, args) =>
            {
                Time = DateTime.Now.ToString("HH:mm:ss");
            };
            _timer.Start();

            Items = new ObservableCollection<MainMenuItemViewModel>();
        }

        #endregion
    }
}