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
    public partial class PackageFirstPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        PackageFirstPageVM PackageVM;
        public PackageFirstPage()
        {
            InitializeComponent();
            PackageVM = new PackageFirstPageVM(this.Navigation);
            this.BindingContext = PackageVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    } 
}