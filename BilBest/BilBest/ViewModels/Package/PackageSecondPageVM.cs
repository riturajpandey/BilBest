using BilBest.Models;
using BilBest.Views.Package;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BilBest.ViewModels.Package
{
    public class PackageSecondPageVM : BaseViewModel
    { 
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageSecondPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public PackageSecondPageVM(INavigation nav)
        {
            Navigation = nav;
            ChoosePackageCommand = new Command(OnChoosePackageAsync);
        }
        #endregion

        #region COMMANDS  
        public Command ChoosePackageCommand { get; set; } 
        #endregion


        #region Properties

        public PackageModel SelectedPackage = new PackageModel();
        private ObservableCollection<PackageModel> _PackageList;
        public ObservableCollection<PackageModel> PackageList
        {
            get { return _PackageList; }
            set
            {
                if (_PackageList != value)
                {
                    _PackageList = value;
                    OnPropertyChanged("PackageList");
                }
            }
        } 
        #endregion

        #region Methods

        public void GetPackages()
        {
            PackageList = new ObservableCollection<PackageModel>(PackageModel.GetPackages()); 
        }

        /// <summary>
        /// TODO : To Go To Choose Package Command ...
        /// </summary>
        public async void OnChoosePackageAsync()
        {
            await Navigation.PushAsync(new PackageDetailPage(SelectedPackage));
        }
        #endregion
    }
}