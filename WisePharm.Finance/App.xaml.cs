using System;
using System.Threading.Tasks;
using System.Windows;

namespace WisePharm.Finance
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            await ApplicationSetupAsync();

            IoC.ApplicationVM.GoToPage(ApplicationPage.Login);

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        private async Task ApplicationSetupAsync()
        {

            //// Setup the Dna Framework
            //new DefaultFrameworkConstruction()
            //    .Build();

            // Setup IoC
            await IoC.Setup();

            // Bind a UI Manager
            IoC.Kernel.Bind<IUIManager>().ToConstant(new UIManager());
            //IoC.Kernel.Bind<IUIManager>().ToConstant(new Test());

        }
    }
}