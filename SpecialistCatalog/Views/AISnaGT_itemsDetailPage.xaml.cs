using SpecialistCatalog.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using SpecialistCatalog.Services;
using System;
using Xamarin.Essentials;

using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AISnaGT_itemsDetailPage : ContentPage
    {
        public AISnaGT_itemsDetailPage()
        {
            InitializeComponent();
            //BindingContext = new AISItemsDetailViewModel();
            BindingContext = new AISItemsDetailViewModel();
        }
        private void OpenBut_Clicked(object sender, System.EventArgs e)
        {
            System.Uri myUri = new System.Uri(ItemLink.Text);
            try
            {
                Browser.OpenAsync(myUri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Ошибка!", "Случилась непредвиденная ошибка. Проверьте подключение к интернету или наличие браузера. Затем повторите попытку.", "OK");
            }
        }
    }
}