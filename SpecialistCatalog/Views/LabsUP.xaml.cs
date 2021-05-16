using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views.UP_Labs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabsUP : ContentPage
    {
        public LabsUP()
        {
            InitializeComponent();
        }

        private async void OnTapGestureRecognizerTappedL1(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UPLab1Detail());
        }

        private async void OnTapGestureRecognizerTappedL2(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UPLab2Detail());
        }
        private async void OnTapGestureRecognizerTappedL3(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UPLab3Detail());
        }
        private async void OnTapGestureRecognizerTappedL4(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UPLab4Detail());
        }
        private async void OnTapGestureRecognizerTappedL5(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UPLab5Detail());
        }
        private async void OnTapGestureRecognizerTappedL6(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UPLab6Detail());
        }

    }
}