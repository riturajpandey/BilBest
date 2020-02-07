using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BilBest.ViewModels.Account
{
    public class SignupFirstPageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..
        private const string _emailRegex = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupFirstPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public SignupFirstPageVM(INavigation nav)
        {
            Navigation = nav;
            ProceedCommand = new Command(OnProceedAsync); 
        }
        #endregion

        #region COMMANDS   
        public Command ProceedCommand { get; set; } 
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

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if (_Email != value)
                {
                    _Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        private string _ImedEmail;
        public string ImedEmail
        {
            get { return _ImedEmail; }
            set
            {
                if (_ImedEmail != value)
                {
                    _ImedEmail = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        private string _TelephoneNum;
        public string TelephoneNum
        {
            get { return _TelephoneNum; }
            set
            {
                if (_TelephoneNum != value)
                {
                    _TelephoneNum = value;
                    OnPropertyChanged("TelephoneNum");
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
        /// TODO : To Go To Second Sign up Page...
        /// </summary>
        public async void OnProceedAsync()
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
            if (string.IsNullOrEmpty(Email))
            {
                UserDialogs.Instance.Alert("Please enter your email.");
                return false;
            }
            if (string.IsNullOrEmpty(TelephoneNum))
            {
                UserDialogs.Instance.Alert("Please enter your Telephone number.");
                return false;
            }
            if (string.IsNullOrEmpty(ImedEmail))
            {
                UserDialogs.Instance.Alert("Please enter your Imed email.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
