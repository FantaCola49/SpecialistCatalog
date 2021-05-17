using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPLab4Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public UPLab4Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1rKRFCYP7xTiQrgtr_GJg0ssYKLwnnM-H/view?usp=sharing", // Разработка расписания PDF
            "https://drive.google.com/file/d/17qGzyYS8OV2dKCzKnQuS1R-Ga4dY3-C0/view?usp=sharing" // План проекта и расписание
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
    }
}