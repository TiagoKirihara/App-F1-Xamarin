using F1.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace F1.ViewModel
{
    public class DriverDetailViewModel : BaseViewModel
    {
        #region propriedade
        private Driver driver;
        public Driver Driver
        {
            get { return driver; }  
            set { SetProperty(ref driver, value); }
        }
        #endregion
        #region commands

        public ICommand OpenBrowserCommand => new Command<Driver>(async (Driver d) =>
        {
            var uri = new Uri("https://www.f1.com");
            await Xamarin.Essentials.Browser.OpenAsync(uri);
        });

        #endregion
        public DriverDetailViewModel()
        {
            Driver = new Driver();
        }
        public DriverDetailViewModel(Driver driver)
        {
            IsBusy = false;
            Driver = driver;            
        }
    }

}
