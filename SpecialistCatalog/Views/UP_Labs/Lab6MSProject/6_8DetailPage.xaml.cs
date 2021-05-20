using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_8DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_8DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1yfR8mO6ouaI6Ko6AqP0pYy4AszfI5pSU/view?usp=sharing", // Лекция о практической работе 8

            "https://drive.google.com/file/d/1Zt9yowlYnbk95EtKyMBssppMSFxL4sIY/view?usp=sharing", // Lesson_08_01
            "https://drive.google.com/file/d/1wXfjpsDXrPWEf7DqsSWlIJdYrSKKsowY/view?usp=sharing", // Lesson_08_02
            "https://drive.google.com/file/d/148AlExBpDI2wB_mEXAJXRF0n0lniX9mN/view?usp=sharing", // Lesson_08_03
            "https://drive.google.com/file/d/18osht0WYHCTNdtS4C6CrTwr_gS5nOypd/view?usp=sharing", // Lesson_08_04
            "https://drive.google.com/file/d/1GtXhXRU6rXRJp-x_AyVkdp7jhSaAEV8z/view?usp=sharing", // Lesson_08_05
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Lesson08_01(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson08_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Lesson08_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
        private void Tapped_Lesson08_04(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }
        private void Tapped_Lesson08_05(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[5]);
        }
    }
}