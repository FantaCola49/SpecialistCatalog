using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPLab5Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public UPLab5Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1CxBBSKi5INXqTcgRkOgKqPyANHmilgnE/view?usp=sharing", // Планирование качества PDF
            "https://drive.google.com/file/d/1U9oSC5ErgrVXB4rjmcZYKgO293Bs02FK/view?usp=sharing" // Пример планирования качества WORD
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