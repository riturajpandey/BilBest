using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BilBest.ViewModels.Account
{
    public class SignupSecondVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..
 
        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupSecondVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public SignupSecondVM(INavigation nav)
        {
            Navigation = nav;
            ProceedCommand = new Command(OnProceedAsync);
        }
        #endregion

        #region COMMANDS   
        public Command ProceedCommand { get; set; }
        #endregion


        #region Properties
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
        private string _ConfirmPassword;
        public string ConfirmPassword
        {
            get { return _ConfirmPassword; }
            set
            {
                if (_ConfirmPassword != value)
                {
                    _ConfirmPassword = value;
                    OnPropertyChanged("ConfirmPassword");
                }
            }
        }
        private bool _Condition1;
        public bool Condition1
        {
            get { return _Condition1; }
            set
            {
                if (_Condition1 != value)
                {
                    _Condition1 = value;
                    OnPropertyChanged("Condition1");
                }
            }
        }
        private bool _Condition2;
        public bool Condition2
        {
            get { return _Condition2; }
            set
            {
                if (_Condition2 != value)
                {
                    _Condition2 = value;
                    OnPropertyChanged("Condition2");
                }
            }
        }
        private bool _PrivacyPolicy;
        public bool PrivacyPolicy
        {
            get { return _PrivacyPolicy; }
            set
            {
                if (_PrivacyPolicy != value)
                {
                    _PrivacyPolicy = value;
                    OnPropertyChanged("PrivacyPolicy");
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
            if (string.IsNullOrEmpty(Password))
            {
                UserDialogs.Instance.Alert("Please enter your password.");
                return false;
            }
            if (string.IsNullOrEmpty(ConfirmPassword))
            {
                UserDialogs.Instance.Alert("Please enter your password again.");
                return false;
            }
            if (Condition1==false)
            {
                UserDialogs.Instance.Alert("Please select condition 1.");
                return false;
            }
            if (Condition2 == false)
            {
                UserDialogs.Instance.Alert("Please select condition 2.");
                return false;
            }
            if (PrivacyPolicy == false)
            {
                UserDialogs.Instance.Alert("Please select condition privacy policy.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
