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
            HorizontalListData = new ObservableCollection<HorizontalListData>
            {
                new HorizontalListData{Name="Gelen Kutusu",BackgroudColor="#FDCB6E",Isvisible=true},
                new HorizontalListData{Name="Epikrizlerim",BackgroudColor="#FFFFFF",Isvisible=false},
                new HorizontalListData{Name="Laboratuvar Sonuçlarım",BackgroudColor="#FFFFFF",Isvisible=false},
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
        private ObservableCollection<HorizontalListData> _HorizontalListData;
        public ObservableCollection<HorizontalListData> HorizontalListData
        {
            get { return _HorizontalListData; }
            set
            {
                if (_HorizontalListData != value)
                {
                    _HorizontalListData = value;
                    OnPropertyChanged("HorizontalListData");
                }
            }
        }
        
        #endregion      
    }
}
