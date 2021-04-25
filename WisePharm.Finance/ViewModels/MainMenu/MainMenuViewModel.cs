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
        /// The variable that stores index of 
        /// </summary>
        public int SelectedIndex { get; set; }


        /// <summary>
        /// The private object that controls all menu items
        /// </summary>
        private ObservableCollection<MainMenuItemViewModel> _items;

        /// <summary>
        /// The public object that implement <see cref="_items"/> list
        /// </summary>
        public ObservableCollection<MainMenuItemViewModel> items
        {
            get
            {
                _items = new ObservableCollection<MainMenuItemViewModel>();

                IndexMain = _items.Count;

                _items.Add(new MainMenuItemViewModel
                {
                    Text = "Главный",
                    Icon = "\uf015",
                    IsSelected = true,
                    ClickCommand = new RelayParametrizedCommand(async (parameter) =>
                    {
                        await GotoPage(ApplicationPage.MainPage);
                    })
                });

                IndexBuy = _items.Count;
                _items.Add(new MainMenuItemViewModel
                {
                    Text = "Главный",
                    Icon = "\uf015",
                    IsSelected = false,
                    ClickCommand = new RelayParametrizedCommand(async (parameter) =>
                    {
                        await GotoPage(ApplicationPage.Login);
                    })
                });

                return _items;
            }

            set
            {
                if (_items != value)
                {
                    _items = value;
                }

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
        public int IndexBuy{ get; set; }

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

        private async Task GotoPage(ApplicationPage page)
        {
            int index = 0;
            switch (page)
            {
                case ApplicationPage.MainPage:
                    index = IndexMain;
                    break;

                case ApplicationPage.Login:
                    index = IndexBuy;
                    break;
            }

            await RunCommandAsync(() => IoC.ApplicationVM.ProgressDialogVisible, async () =>
            {
                if(page == ApplicationPage.MainPage)
                {
                    IoC.ApplicationVM.GotoPage(page, new MainPageViewModel());
                }
                else if (page == ApplicationPage.Login)
                {
                    IoC.ApplicationVM.GotoPage(page, new LoginPageViewModel());
                }

                items[SelectedIndex].IsSelected = false;

                SelectedIndex = index;

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

            items = new ObservableCollection<MainMenuItemViewModel>();
        }

        #endregion
    }
}