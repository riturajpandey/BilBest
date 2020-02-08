using BilBest.Models;
using BilBest.Views.Package;
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
                PackageTickImage = "bluecheck.png";
            else
                PackageTickImage = "pinkcheck.png";

            PackageName = selectedPackage.Title;
            PackageAmount = selectedPackage.ActualAmount ;

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
        #endregion

        #region Methods

        public void GetPackages()
        {

        }

        /// <summary>
        /// TODO : To Go To Paymnet Package Command ...
        /// </summary>
        public async void OnChoosePackageAsync()
        {
            await Navigation.PushAsync(new PackagePaymentPage(SelectedPackage));
        }
        #endregion
    }
}