using System;
using SpecialistCatalog.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views.UP_Labs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UPLab1Detail : ContentPage
    {
        OpenInBrowser inBrowser;
        public UPLab1Detail()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1E71m2Rqgigz4t5wr5O4P8KPl76EFYhTu/view?usp=sharing",
            "https://drive.google.com/file/d/1DvgrLo1kY74j1ok4FxBVMCvKCHIQrg6d/view?usp=sharing",
            "https://drive.google.com/file/d/19V-Z2jIMYH-BAUmYrGMttAnbXWNQlMlY/view?usp=sharing",
            "https://drive.google.com/file/d/1vhHCLKoQM16nemQNQAQY0_GeMhiQBISb/view?usp=sharing",
            "https://drive.google.com/file/d/1VUhWM2nrAOUEyzsHQiaC-RX2ruEdLAZF/view?usp=sharing",
            "https://drive.google.com/file/d/1EgGRIF_KYbtkxcSoDeuaKZy4hJDsdWrR/view?usp=sharing",
            "https://drive.google.com/file/d/1evXeaD-W9LLsAJFL44UUi0GIbdH4PYWx/view?usp=sharing",
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

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[5]);
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[6]);
        }
    }
}