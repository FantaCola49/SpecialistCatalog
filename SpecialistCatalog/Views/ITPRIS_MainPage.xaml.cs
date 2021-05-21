using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.Views.ITPRIS;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ITPRIS_MainPage : ContentPage
    {
        public ITPRIS_MainPage()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_ToLabs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ITPRIS_Labs());
        }
        private void TapGestureRecognizer_ToMaterials(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ITPRIS_Materials());
        }
    }
}