using F1.Data;
using F1.Model;
using F1.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace F1.ViewModel
{
    public class DriversViewModel : BaseViewModel
    {
        private readonly DriverRepository driverRepository;

        private ObservableCollection<Driver> drivers;

        public ObservableCollection<Driver> Drivers
        {
            get { return drivers; }
            set { SetProperty(ref drivers, value); }
        }

        public ICommand OpenDriverDetailCommand => new Command<Driver>(async (Driver d) =>
        {
            var vm = new DriverDetailViewModel(d);
            await App.Current.MainPage.Navigation.PushAsync(new DriverDetailView(vm));
        });
        private Driver selectedDriver;

        public Driver SelectedDriver
        {
            get { return selectedDriver; }
            set { SetProperty(ref selectedDriver, value); }
        }

        public DriversViewModel()
        {
            driverRepository = new DriverRepository();
            Drivers = new ObservableCollection<Driver>(driverRepository.FindAll());
        }
        public DriversViewModel(ObservableCollection<Driver> drivers)
        {
            Drivers = drivers;
        }

    }
}
