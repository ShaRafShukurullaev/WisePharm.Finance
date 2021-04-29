using System.Windows.Input;

namespace WisePharm.Finance
{
    public class LoginPageViewModel : BaseViewModel
    {

        #region Public Proepries

        /// <summary>
        /// Edit login 
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Edit parol 
        /// </summary>
        public string Parol { get; set; }

        #endregion


        #region Public commands 

        /// <summary>
        /// SQL Command
        /// </summary>
        public ICommand SQLCommand { get; set; }

        /// <summary>
        /// DBF Command
        /// </summary>
        public ICommand DBFCommand { get; set; }

        /// <summary>
        /// Come in command 
        /// </summary>
        public ICommand ToComeInCommand { get; set; }

        /// <summary>
        /// Register command
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginPageViewModel()
        {

        }
        #endregion
    }
}
