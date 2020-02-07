using BilBest.ViewModels.Welcome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BilBest.Views.Welcome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        //Define Properties Here
        protected WelcomePageVM WelcomePageVM;

        #region Constructor
        public WelcomePage()
        {
            InitializeComponent();
            WelcomePageVM = new WelcomePageVM(this.Navigation);
            BindingContext = WelcomePageVM;
            cardlistview.ItemsSource = WelcomePageVM.WelcomeList;
        } 
        #endregion
    }
}