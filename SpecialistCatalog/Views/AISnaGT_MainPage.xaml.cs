using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //await Navigation.PushAsync(new );
        }
        private async void TapGestureRecognizer_ToMaterials(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AISnaGT_items());
        }
    }
}