using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_4DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_4DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1BENkuBFcDBNF9c0yW4mzGxQkoTvUHXow/view?usp=sharing", // Отчёт о практической работе 4

            "https://drive.google.com/file/d/1mT5f2dMv6KscrCPsQ9m_C35PCvApy4t_/view?usp=sharing", // Lesson_04_01.mpp
            "https://drive.google.com/file/d/1x6mytmLb82LtLZbi-32RLvDW7USNGNOl/view?usp=sharing", // Lesson_04_02.mpp
            "https://drive.google.com/file/d/1_PAPmfsvRcM5PGbDrw5OWL-UW9J0Osbz/view?usp=sharing", // Lesson_04_03.mpp
            "https://drive.google.com/file/d/194iqdxk2x4KH2Pzw0LdAhMQi1cqpM8Jn/view?usp=sharing" // Lesson_04_04.mpp
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Lesson04_01(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson04_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Lesson04_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
        private void Tapped_Lesson04_04(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }
    }
}