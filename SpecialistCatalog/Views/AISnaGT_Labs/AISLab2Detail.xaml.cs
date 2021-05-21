using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.AISnaGT_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AISLab2Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public AISLab2Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[5]
        {
            "https://drive.google.com/file/d/1k8_pswm68IevZ_zsZ9-QtytrJgrGBTPA/view?usp=sharing", // Лабораторная работа 2

            "https://drive.google.com/file/d/1HlD5VCimdJw0C9y-09Ivc-FkLVZ6Enfv/view?usp=sharing", // Excel таблица с расчётами
            "https://drive.google.com/file/d/1cNDs3kkeHqEx5rFzj_U2nRPuNsECCIAg/view?usp=sharing", // 1 Страница конспекта
            "https://drive.google.com/file/d/1OwCauDaImMOVXupS2zxwW4emYAvyK7I2/view?usp=sharing", // 2 Страница конспекта
            "https://drive.google.com/file/d/1JpM1V-xBuGyTeKkPfrNMjxhyqWbn4Mdy/view?usp=sharing", // 3 Страница конспекта

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
        private void Tapped_Pg3(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }

    }
}