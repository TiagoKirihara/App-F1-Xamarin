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
    public partial class DriverDetailView : ContentPage
    {
        public DriverDetailView(Driver driver)
        {
            InitializeComponent();
            BindingContext = driver;

            LabelTeam.Text = driver.Team;
            LabelCountry.Text = driver.Country;
        }
    }
}