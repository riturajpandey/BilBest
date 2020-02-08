using BilBest.Models;
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
        private ObservableCollection<IndicatorModel> _IndicatorList;
        public ObservableCollection<IndicatorModel> IndicatorList
        {
            get { return _IndicatorList; }
            set
            {
                if (_IndicatorList != value)
                {
                    _IndicatorList = value;
                    OnPropertyChanged("IndicatorList");
                }
            }
        }
        #endregion

        #region Methods

        public void GetPackages()
        {
            PackageList = new ObservableCollection<PackageModel>(PackageModel.GetPackages());
            IndicatorList = new ObservableCollection<IndicatorModel>();
            var indicatorList = new ObservableCollection<IndicatorModel>();
            int first = 0;
            foreach (var item in PackageList)
            {

                IndicatorModel objIndicator = new IndicatorModel();
                if (first == 0)
                {
                    objIndicator.IsCurrent = true;
                    objIndicator.IsNotCurrent = false;
                    first = 1;
                }
                else
                {
                    objIndicator.IsCurrent = false;
                    objIndicator.IsNotCurrent = true;
                }
                objIndicator.Id = item.Id.ToString();
                indicatorList.Add(objIndicator);
            }
            IndicatorList = indicatorList;
        }
        #endregion
    }
}