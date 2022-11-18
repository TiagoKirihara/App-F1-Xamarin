using F1.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
        public DriverDetailViewModel()
        {
            Driver = new Driver();
        }
        public DriverDetailViewModel(Driver driver)
        {
            Driver = driver;
        }
    }

}
