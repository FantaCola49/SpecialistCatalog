using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views.AISnaGT_Labs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views.AISnaGT_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AIS_Labs_Main : ContentPage
    {
        public AIS_Labs_Main()
        {
            InitializeComponent();
        }

        private void Tapped_ToLab1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AISLab1Detail());
        }
        private void Tapped_ToLab2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AISLab2Detail());
        }
        private void Tapped_ToLab3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AISLab3Detail());
        }
    }
}