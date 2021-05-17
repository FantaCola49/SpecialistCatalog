using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPLab2Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public UPLab2Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
        }
        readonly string[] links = new string[4]
        {
            "https://drive.google.com/file/d/1H02MYBxeHWqcfdzgBTje97XnBMgDrMn5/view?usp=sharing", // N1 ТЭО Web-сайт
            "https://drive.google.com/file/d/1H02MYBxeHWqcfdzgBTje97XnBMgDrMn5/view?usp=sharing", // N2 ТЭО АРМ
            "https://drive.google.com/file/d/1H02MYBxeHWqcfdzgBTje97XnBMgDrMn5/view?usp=sharing", // N3 ТЭО АРМ "Автосалон"
            "https://drive.google.com/file/d/1H02MYBxeHWqcfdzgBTje97XnBMgDrMn5/view?usp=sharing", // Расчёты для №3
        };

        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
    }
}