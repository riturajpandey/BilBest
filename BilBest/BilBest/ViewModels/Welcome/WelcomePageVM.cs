using BilBest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BilBest.ViewModels.Welcome
{
    public class WelcomePageVM : BaseViewModel
    {
        #region Constructor
        public WelcomePageVM(INavigation nav)
        {
            Navigation = nav;
            WelcomeList = new ObservableCollection<WelcomePageModel>
            {
                new WelcomePageModel{Image="medicine.png",SubTitle="Cebinizde ki",Title="Doktorunuz",Description="Bu alana tanıtım kartları, sloganları ve yazılar eklenebilir. Kayar slider şeklinde ve sayısı belirlenebilir. Ama maksimum 5 tane yeterlidir."},
                new WelcomePageModel{Image="medicine.png",SubTitle="Cebinizde ki",Title="Doktorunuz",Description="Bu alana tanıtım kartları, sloganları ve yazılar eklenebilir. Kayar slider şeklinde ve sayısı belirlenebilir. Ama maksimum 5 tane yeterlidir."},
                new WelcomePageModel{Image="medicine.png",SubTitle="Cebinizde ki",Title="Doktorunuz",Description="Bu alana tanıtım kartları, sloganları ve yazılar eklenebilir. Kayar slider şeklinde ve sayısı belirlenebilir. Ama maksimum 5 tane yeterlidir."},
                new WelcomePageModel{Image="medicine.png",SubTitle="Cebinizde ki",Title="Doktorunuz",Description="Bu alana tanıtım kartları, sloganları ve yazılar eklenebilir. Kayar slider şeklinde ve sayısı belirlenebilir. Ama maksimum 5 tane yeterlidir."},
            };
        }
        #endregion

        #region Properties
        private ObservableCollection<WelcomePageModel> _WelcomeList;
        public ObservableCollection<WelcomePageModel> WelcomeList
        {
            get { return _WelcomeList; }
            set
            {
                if (_WelcomeList != value)
                {
                    _WelcomeList = value;
                    OnPropertyChanged("WelcomeList");
                }
            }
        }
        #endregion
    }
}
