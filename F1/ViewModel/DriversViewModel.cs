using F1.Data;
using F1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
