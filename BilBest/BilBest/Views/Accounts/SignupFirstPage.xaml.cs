﻿using BilBest.ViewModels.Account;
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
        SignupFirstPageVM SignUpVM;

        public SignupFirstPage()
        {
            InitializeComponent();
            SignUpVM = new SignupFirstPageVM(this.Navigation);
            this.BindingContext = SignUpVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}