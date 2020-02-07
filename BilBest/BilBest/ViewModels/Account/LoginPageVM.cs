using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BilBest.ViewModels.Account
{
    public class LoginPageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..
        private const string _emailRegex = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public LoginPageVM(INavigation nav)
        {
            Navigation = nav; 
            LoginCommand = new Command(OnLoginAsync);
            ForgetPasswordCommand = new Command(OnForgetPasswordAsync);
        }
        #endregion

        #region COMMANDS  
        public Command RememberMeCommand { get; set; }
        public Command LoginCommand { get; set; }
        public Command ForgetPasswordCommand { get; set; }
        #endregion


        #region Properties
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (_UserName != value)
                {
                    _UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        private bool _RemberMe;
        public bool RememberMe
        {
            get { return _RemberMe; }
            set
            {
                if (_RemberMe != value)
                {
                    _RemberMe = value;
                    OnPropertyChanged("RememberMe");
                }
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate To Forget Password Page...
        /// </summary>
        public async void OnForgetPasswordAsync()
        { }

        /// <summary>
        /// TODO : To Define Login User Command ...
        /// </summary>
        public async void OnLoginAsync()
        {
            //Apply Validations..
            if (!await Validate()) return;
            try
            {
                //Call Login Api.. 
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// TODO : To Validate User Login Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                UserDialogs.Instance.Alert("Please enter your username.");
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                UserDialogs.Instance.Alert("Please enter your password.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
