using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views.UP_Labs.Lab6MSProject;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views.UP_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPLab6Detail : ContentPage
    {
        public UPLab6Detail()
        {
            InitializeComponent();
        }
        private async void Tapped_ToLab2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_2DetailPage());
        }
        private async void Tapped_ToLab3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_3DetailPage());
        }
        private async void Tapped_ToLab4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_4DetailPage());
        }
        private async void Tapped_ToLab5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_5DetailPage());
        }
        private async void Tapped_ToLab6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_6DetailPage());
        }
        private async void Tapped_ToLab7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_7DetailPage());
        }
        private async void Tapped_ToLab8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new _6_8DetailPage());
        }
    }
}