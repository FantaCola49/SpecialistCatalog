using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPLab3Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public UPLab3Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1M2iwet03lnx7p3zxr-NE0-ciafGJr8FG/view?usp=sharing",
            "https://drive.google.com/file/d/1rc0kbvtFuKx0s-gILMUIPaEcb4ytPENP/view?usp=sharing",
            "https://drive.google.com/file/d/1n4hsaysPmj4jcQRv39xaur7WMofRyIod/view?usp=sharing",
            "https://drive.google.com/file/d/1Uao4dLZbYIymuvcaXTQ64IDsTsM_Dtha/view?usp=sharing",
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