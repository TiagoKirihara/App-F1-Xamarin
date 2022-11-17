using F1.Data;
using F1.Model;
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
        private readonly DriverRepository driverRepository;

        public IList<Driver> ListaDrivers { get; set; }
        public DriversView()
        {
            InitializeComponent();
            driverRepository = new DriverRepository();
            ListaDrivers = driverRepository.FindAll();


            BindingContext = this;
            //ListViewDrivers.ItemsSource = listaDrivers;

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var driver = (Driver)e.Item;
            Navigation.PushAsync(new DriverDetailView(driver));
        }


    }
}