using System;
using System.Diagnostics;
using System.Globalization;

namespace WisePharm.Finance
{
    /// Create by Mr.Cyber
	///<summarly>
    /// 
    ///</summarly>
    public static class ApplicationPageHelper
    {

        public static BasePage ToBasePage(this ApplicationPage page, object viewModel = null)
        {
            // Find the appropriate page
            switch (page)
            {
                //case ApplicationPage.Login:
                //    return new LoginPage(viewModel as LoginPageViewModel);


                default:
                    //Debugger.Break();
                    return null;
            }
        }

        /// <summary>
        /// Converts a <see cref="BasePage"/> to the specific <see cref="ApplicationPage"/> that is for that type of page
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static ApplicationPage ToApplicationPage(this BasePage page)
        {
            // Find application page that matches the base page

            //if (page is LoginPage)
            //    return ApplicationPage.Login;


            return default(ApplicationPage);
        }

    }
}