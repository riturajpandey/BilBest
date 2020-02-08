using BilBest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BilBest.ViewModels.Package
{
    public class PackageFirstPageVM : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageFirstPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public PackageFirstPageVM(INavigation nav)
        {
            Navigation = nav;
        }
        #endregion

        #region Properties
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
        #endregion
    }
}