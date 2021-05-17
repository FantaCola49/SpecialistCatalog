using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SpecialistCatalog.Services
{
    public class OpenInBrowser : ContentPage
    {
        public void OpenBrowser (string uri)
        {
            Uri myUri = new Uri(uri);
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
