using BilBest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BilBest.ViewModels.Health
{
    public class MyHealthRecordsVM : BaseViewModel
    {
        #region Constructor
        public MyHealthRecordsVM(INavigation nav)
        {
            Navigation = nav;
            DummyMyHealthRecordsList = new ObservableCollection<DummyMyHealthRecordsModel>
            {
                new DummyMyHealthRecordsModel{Tarih="12.08.2019",Gönderen="Sağlık Kurumu",Dosya="Epikriz Raporu"},
                new DummyMyHealthRecordsModel{Tarih="10.08.2019",Gönderen="Sağlık Kurumu",Dosya="Laboratuvar Sonuçları"},
                new DummyMyHealthRecordsModel{Tarih="10.08.2019",Gönderen="Kullanıcı",Dosya="Laboratuvar Sonuçları"},
            };
        }
        #endregion

        #region Properties
        private ObservableCollection<DummyMyHealthRecordsModel> _DummyMyHealthRecordsList;
        public ObservableCollection<DummyMyHealthRecordsModel> DummyMyHealthRecordsList
        {
            get { return _DummyMyHealthRecordsList; }
            set
            {
                if (_DummyMyHealthRecordsList != value)
                {
                    _DummyMyHealthRecordsList = value;
                    OnPropertyChanged("HealthRecommendationsList");
                }
            }
        }
        #endregion      
    }
}
