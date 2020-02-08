using BilBest.Models;
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
    public partial class PackagePaymentPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        PackagePaymentPageVM PackageVM;

        public PackagePaymentPage (PackageModel selectedPackage)
        {
            InitializeComponent();
            PackageVM = new PackagePaymentPageVM(this.Navigation, selectedPackage);
            this.BindingContext = PackageVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}