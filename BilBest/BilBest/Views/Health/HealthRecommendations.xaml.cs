using BilBest.ViewModels.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BilBest.Views.Health
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HealthRecommendations : ContentPage
    {
        //Define Properties Here
        protected HealthRecommendationsVM HealthRecommendationsVM;

        #region Constructor
        public HealthRecommendations()
        {
            InitializeComponent();
            HealthRecommendationsVM = new HealthRecommendationsVM(this.Navigation);
            BindingContext = HealthRecommendationsVM;
        } 
        #endregion
    }
}