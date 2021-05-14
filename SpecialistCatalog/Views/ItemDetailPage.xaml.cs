using SpecialistCatalog.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using SpecialistCatalog.Services;
using System;
using Xamarin.Essentials;

namespace SpecialistCatalog.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
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
               DisplayAlert("Ошибка!","Случилась непредвиденная ошибка. Проверьте подключение к интернету или наличие браузера. Затем повторите попытку.","OK");
            }
        }
    }
}