using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPMainPage : ContentPage
    {
        public UPMainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_ToLabs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LabsUP());
        }
        private async void TapGestureRecognizer_ToMaterials(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
    }
}