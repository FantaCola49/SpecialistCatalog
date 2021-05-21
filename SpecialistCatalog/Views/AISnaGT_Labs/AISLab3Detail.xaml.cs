using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.AISnaGT_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AISLab3Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public AISLab3Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[4]
        {
            "https://drive.google.com/file/d/1TtYVaWGEyi7f4Ibkqy_GB6vVbP8YGfnd/view?usp=sharing", // Задание на практическую работу 3

            "https://drive.google.com/file/d/1GgQ7Kup_Z2KH0Cve9yM_jLXxtEqayhuP/view?usp=sharing", // Отчёт по работе №3
            "https://drive.google.com/file/d/1elyEUykiv7YgOnAYgR1Uj7D7g4hD2riQ/view?usp=sharing", // 1 страница конспекта
            "https://drive.google.com/file/d/13z82qR7rmKuC9frZlSxvdjUxfRhOTZbv/view?usp=sharing", // 2 страница конспекта
        };

        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Report(object sender, EventArgs e)
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