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
    public partial class MyHealthRecords : ContentPage
    {
        //Define Properties Here
        protected MyHealthRecordsVM MyHealthRecordsVM;
        #region Constructor
        public MyHealthRecords()
        {
            InitializeComponent();
            MyHealthRecordsVM = new MyHealthRecordsVM(this.Navigation);
            BindingContext = MyHealthRecordsVM;
            var data = Color.FromHex(Application.Current.Resources["AppBlueColor"].ToString());
        } 
        #endregion
    }
}