using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.AISnaGT_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AISLab1Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public AISLab1Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[4]
        {
            "https://drive.google.com/file/d/1QXKLXWMX4xd_YwcqMVAW2M8ef0wTdGXz/view?usp=sharing", //Лабораторная работа №1

            "https://drive.google.com/file/d/1p4AQ6XtmoAAdjUYEZwE2TRoYiHhmrYIT/view?usp=sharing", // Excel файл с формулами
            "https://drive.google.com/file/d/122JK3SzckDeJOQtobqXKgEG7YbB5kNeh/view?usp=sharing", //1 Страница конспекта
            "https://drive.google.com/file/d/14kAfn1pLv4p2SBTFrIG0kkjmJxhTjrlh/view?usp=sharing" //2 Страница конспекта
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_ExcelForm(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Pg1(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Pg2(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
    }
}