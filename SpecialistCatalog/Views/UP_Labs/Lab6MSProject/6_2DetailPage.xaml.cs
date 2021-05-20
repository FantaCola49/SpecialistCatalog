using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_2DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_2DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1jvxOhg3U5_XzpLLuy6IXGkf2fwEtpv73/view?usp=sharing", // Отчёт о второй практической
            
            "https://drive.google.com/file/d/1C-V3idm31wl6V3AKqKUhDBbQ93t01YNh/view?usp=sharing", //Lesson_02_02.mpp
            "https://drive.google.com/file/d/1Dqw5t3rzK8P2i9lfMu2HIcU8d9KafD_z/view?usp=sharing" //Lesson_02_03.mpp
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Lesson02_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson02_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
    }
}