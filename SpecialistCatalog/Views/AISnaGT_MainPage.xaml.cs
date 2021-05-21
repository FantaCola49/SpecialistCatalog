using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views.AISnaGT_Labs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AISnaGT_MainPage : ContentPage
    {
        public AISnaGT_MainPage()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_ToLabs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AIS_Labs_Main());
        }
        private void TapGestureRecognizer_ToMaterials(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AISnaGT_items());
        }
    }
}