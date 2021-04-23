
using Ninject;
using System;
using System.Threading.Tasks;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// This is IoC container for our application
    ///</summarly>
    public static class IoC
    {
        #region Public properties 

        /// <summary>
        /// The kernel for this IoC Container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// 
        /// </summary>
        public static ApplicationViewModel ApplicationVM => IoC.Get<ApplicationViewModel>();

        #endregion

        #region Constructor

        public static async Task Setup()
        {
            await BindViewModel();
        }

        private static async Task BindViewModel()
        {
            await Task.Delay(1);
            // Bind to a single instance of Application view model
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());

        }

        /// <summary>
        /// Get's a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }


        #endregion
    }
}