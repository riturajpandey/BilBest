using BilBest.Models;
using BilBest.ViewModels.Package;
using Plugin.InputKit;
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
        int pkgPosition = 0;
        bool islistRefresh = false;

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
            LvPackages.ItemsSource = PackageVM.PackageList;
        }

        /// <summary>
        /// TODO : To Define On Carousel Changed event...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            var index = e.NewValue;
            if (islistRefresh == false)
                pkgPosition = LvPackages.Position;

            PackageVM.SelectedPackage = PackageVM.PackageList.Where(a => a.Id == LvPackages.Position + 1).FirstOrDefault();
        }

        /// <summary>
        /// TODO : To Define Event Handler For Lectus Radio button tapped...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LectusRadioButton_Checked(object sender, EventArgs e)
        {
            var item = (sender as Plugin.InputKit.Shared.Controls.RadioButton).BindingContext as PackageModel;
            if (item != null)
            {
                foreach (var pkg in PackageVM.PackageList)
                {
                    if (item.Id == pkg.Id)
                    {
                        if (item.IsLectus)
                            pkg.IsLectus = false;
                        else
                            pkg.IsLectus = true;
                    }
                }
                islistRefresh = true;
                LvPackages.ItemsSource = null;
                LvPackages.ItemsSource = PackageVM.PackageList;
                LvPackages.Position = pkgPosition;
                islistRefresh = false;
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For Prions Radio button tapped...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrionsRadioButton_Checked(object sender, EventArgs e)
        {
            var item = (sender as Plugin.InputKit.Shared.Controls.RadioButton).BindingContext as PackageModel;
            if (item != null)
            {
                foreach (var pkg in PackageVM.PackageList)
                {
                    if (item.Id == pkg.Id)
                    {
                        if (item.IsPrions)
                            pkg.IsPrions = false;
                        else
                            pkg.IsPrions = true;
                    }
                }
                islistRefresh = true;
                LvPackages.ItemsSource = null;
                LvPackages.ItemsSource = PackageVM.PackageList;
                LvPackages.Position = pkgPosition;
                islistRefresh = false;
            }
        }

        /// <summary>
        /// TODO : To Define Event Handler For Consec Radio button tapped...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsecRadioButton_Checked(object sender, EventArgs e)
        {
            var item = (sender as Plugin.InputKit.Shared.Controls.RadioButton).BindingContext as PackageModel;
            if (item != null)
            {
                foreach (var pkg in PackageVM.PackageList)
                {
                    if (item.Id == pkg.Id)
                    {
                        if (item.IsConsec)
                            pkg.IsConsec = false;
                        else
                            pkg.IsConsec = true;
                    }
                }
                islistRefresh = true;
                LvPackages.ItemsSource = null;
                LvPackages.ItemsSource = PackageVM.PackageList;
                LvPackages.Position = pkgPosition;
                islistRefresh = false;
            }
        }
        #endregion

    }
}