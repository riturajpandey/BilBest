using BilBest.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace BilBest.Views.Accounts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupFirstPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        SignupFirstPageVM LoginVM;

        public SignupFirstPage()
        {
            InitializeComponent();
            LoginVM = new SignupFirstPageVM(this.Navigation);
            this.BindingContext = LoginVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}