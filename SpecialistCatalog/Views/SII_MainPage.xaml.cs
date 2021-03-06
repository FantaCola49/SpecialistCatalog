using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views.SII;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SII_MainPage : ContentPage
    {
        public SII_MainPage()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_ToLabs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SII_Labs());
        }
        private async void TapGestureRecognizer_ToMaterials(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SII_Materials());
        }
    }
}