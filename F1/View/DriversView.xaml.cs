using F1.Data;
using F1.Model;
using F1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace F1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriversView : ContentPage
    {
        public DriversView()
        {
            InitializeComponent();
            BindingContext = new DriversViewModel();

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var driver = (Driver)e.Item;
            var vm = new DriverDetailViewModel(driver);
            Navigation.PushAsync(new DriverDetailView(vm));
        }


    }
}