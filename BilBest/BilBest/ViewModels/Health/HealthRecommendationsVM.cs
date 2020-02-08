using BilBest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BilBest.ViewModels.Health
{
    public class HealthRecommendationsVM : BaseViewModel
    {
        #region Constructor
        public HealthRecommendationsVM(INavigation nav)
        {
            Navigation = nav;
            HealthRecommendationsList = new ObservableCollection<DummyHealthRecommendationsModel>
            {
                new DummyHealthRecommendationsModel{Image="",Title="Kolesterolunuzda yükselme gözlemledik.",
                                                    Description="Bu alana sağlık önerileri veya tavsiyelerinin Belirtildiği yazılar gelecek. Birden fazla öneri Varsa yan kaymalı olacak ve acilse kırmızı …"},
                 new DummyHealthRecommendationsModel{Image="medicalparkimg.png",Title="Kolesterolunuzda yükselme gözlemledik.",
                                                    Description="Bu alana sağlık önerileri veya tavsiyelerinin Belirtildiği yazılar gelecek. Birden fazla öneri Varsa yan kaymalı olacak ve acilse kırmızı …"},
                  new DummyHealthRecommendationsModel{Image="",Title="Kolesterolunuzda yükselme gözlemledik.",
                                                    Description="Bu alana sağlık önerileri veya tavsiyelerinin Belirtildiği yazılar gelecek. Birden fazla öneri Varsa yan kaymalı olacak ve acilse kırmızı …"},
                   new DummyHealthRecommendationsModel{Image="medicalparkimg.png",Title="Kolesterolunuzda yükselme gözlemledik.",
                                                    Description="Bu alana sağlık önerileri veya tavsiyelerinin Belirtildiği yazılar gelecek. Birden fazla öneri Varsa yan kaymalı olacak ve acilse kırmızı …"},
            };
        }
        #endregion

        #region Properties
        private ObservableCollection<DummyHealthRecommendationsModel> _HealthRecommendationsList;
        public ObservableCollection<DummyHealthRecommendationsModel> HealthRecommendationsList
        {
            get { return _HealthRecommendationsList; }
            set
            {
                if (_HealthRecommendationsList != value)
                {
                    _HealthRecommendationsList = value;
                    OnPropertyChanged("HealthRecommendationsList");
                }
            }
        }
        #endregion
    }
}
