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
    public partial class DriverDetailView : ContentPage
    {
        public DriverDetailView(DriverDetailViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

            //LabelTeam.Text = driver.Team;
            //LabelCountry.Text = driver.Country;
        }
        
    }
}