using BilBest.ViewModels.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace BilBest.Views.Package
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PackageSecondPage : ContentPage
    {  
        //TODO : To Define class Level Variables...
        PackageSecondPageVM PackageVM;
        public PackageSecondPage()
        {
            InitializeComponent();
            PackageVM = new PackageSecondPageVM(this.Navigation);
            this.BindingContext = PackageVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region Event Handlers

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PackageVM.GetPackages();
        }


        /// <summary>
        /// TODO : To Define On Carousel Changed event...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            var index = e.NewValue;
            ////var item = e.SelectedItem as Value;
            //if (PackageVM.IntroductionList != null)
            //{
            //    var item = PackageVM.IntroductionList.ElementAt(index);

            //    //For Indicators
            //    foreach (var inditem in PackageVM.IndicatorList)
            //    {
            //        if (inditem.Id == item.ID)
            //        {
            //            inditem.IsCurrent = true;
            //            inditem.IsNotCurrent = false;
            //        }
            //        else
            //        {
            //            inditem.IsCurrent = false;
            //            inditem.IsNotCurrent = true;
            //        }
            //    }
            //    LvIndicators.ItemsSource = null;
            //    LvIndicators.ItemsSource = IntroVm.IndicatorList;
            //}
        }
        #endregion
    }
}