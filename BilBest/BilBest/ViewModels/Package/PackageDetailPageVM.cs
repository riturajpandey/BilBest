using BilBest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BilBest.ViewModels.Package
{
    public class PackageDetailPageVM : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageSecondPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public PackageDetailPageVM(INavigation nav, PackageModel selectedPackage)
        {
            Navigation = nav;
            ChoosePackageCommand = new Command(OnChoosePackageAsync);
            SelectedPackage = selectedPackage;
            PackageColor = selectedPackage.PkgColor;
            if (selectedPackage.Id == 1)
                PackageTickImage = "";
            else
                PackageTickImage = "pinkcheck.png";

        }
        #endregion

        #region COMMANDS  
        public Command ChoosePackageCommand { get; set; }

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
        #endregion


        #region Properties

        public PackageModel SelectedPackage = new PackageModel();


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
            //await Navigation.PushAsync(new PackageDetailPage(SelectedPackage));
        }
        #endregion
    }
}