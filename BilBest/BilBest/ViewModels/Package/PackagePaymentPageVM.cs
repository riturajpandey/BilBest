using Acr.UserDialogs;
using BilBest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BilBest.ViewModels.Package
{
    public class PackagePaymentPageVM : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PackagePaymentPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public PackagePaymentPageVM(INavigation nav, PackageModel selectedPackage)
        {
            Navigation = nav;
            ChoosePackageCommand = new Command(OnChoosePackageAsync);
            SelectedPackage = selectedPackage;
            PackageColor = selectedPackage.PkgColor;
            if (selectedPackage.Id == 1)
                PackageTickImage = "blueframe.png";
            else
                PackageTickImage = "pinkframe.png";

            PackageName = selectedPackage.Title;
            PackageAmount = selectedPackage.ActualAmount;

        }
        #endregion

        #region COMMANDS  
        public Command ChoosePackageCommand { get; set; }

        #endregion


        #region Properties

        public PackageModel SelectedPackage = new PackageModel();


        private string _PackageColor;
        public string PackageColor
        {
            get { return _PackageColor; }
            set
            {
                if (_PackageColor != value)
                {
                    _PackageColor = value;
                    OnPropertyChanged("PackageColor");
                }
            }
        }
        private string _PackageColorImg;
        public string PackageTickImage
        {
            get { return _PackageColorImg; }
            set
            {
                if (_PackageColorImg != value)
                {
                    _PackageColorImg = value;
                    OnPropertyChanged("PackageTickImage");
                }
            }
        }
        private string _PackageName;
        public string PackageName
        {
            get { return _PackageName; }
            set
            {
                if (_PackageName != value)
                {
                    _PackageName = value;
                    OnPropertyChanged("PackageName");
                }
            }
        }
        private string _PackageAmount;
        public string PackageAmount
        {
            get { return _PackageAmount; }
            set
            {
                if (_PackageAmount != value)
                {
                    _PackageAmount = value;
                    OnPropertyChanged("PackageAmount");
                }
            }
        }
        private string _NameOnCard;
        public string NameOnCard
        {
            get { return _NameOnCard; }
            set
            {
                if (_NameOnCard != value)
                {
                    _NameOnCard = value;
                    OnPropertyChanged("NameOnCard");
                }
            }
        }
        private string _CardNumber;
        public string CardNumber
        {
            get { return _CardNumber; }
            set
            {
                if (_CardNumber != value)
                {
                    _CardNumber = value;
                    OnPropertyChanged("CardNumber");
                }
            }
        }
        private string _CardExpiration;
        public string CardExpiration
        {
            get { return _CardExpiration; }
            set
            {
                if (_CardExpiration != value)
                {
                    _CardExpiration = value;
                    OnPropertyChanged("CardExpiration");
                }
            }
        }
        private string _CVC;
        public string CVC
        {
            get { return _CVC; }
            set
            {
                if (_CVC != value)
                {
                    _CVC = value;
                    OnPropertyChanged("CVC");
                }
            }
        }
        private bool _Agreement;
        public bool Agreement
        {
            get { return _Agreement; }
            set
            {
                if (_Agreement != value)
                {
                    _Agreement = value;
                    OnPropertyChanged("Agreement");
                }
            }
        }
        #endregion

        #region Methods

        public void GetPackages()
        {

        }

        /// <summary>
        /// TODO : To Go To Choose Package Command ...
        /// </summary>
        public async void OnChoosePackageAsync()
        {
            ///Apply Validations..
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
            if (string.IsNullOrEmpty(NameOnCard))
            {
                UserDialogs.Instance.Alert("Please enter your Card Name.");
                return false;
            }
            if (string.IsNullOrEmpty(CardNumber))
            {
                UserDialogs.Instance.Alert("Please enter your Card Number.");
                return false;
            }
            if (string.IsNullOrEmpty(CardExpiration))
            {
                UserDialogs.Instance.Alert("Please enter your Card expiry date.");
                return false;
            }
            if (string.IsNullOrEmpty(CVC))
            {
                UserDialogs.Instance.Alert("Please enter your CVC.");
                return false;
            }
            return true;
        }
        #endregion
    }
}