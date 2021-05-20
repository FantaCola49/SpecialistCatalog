using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_6DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_6DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1XD_17BpOfngNPPIav0NTx5AKgiPtIEN8/view?usp=sharing", // Отчёт о практической работе 6

            "https://drive.google.com/file/d/1xhFVGosllh-LKRTXjpFXGXXpPvj7Ggt2/view?usp=sharing", // Lesson_06_01
            "https://drive.google.com/file/d/1Re55iCWSH6MUJd3Xk7R2k0lZFLOv8qL6/view?usp=sharing", // Lesson_06_02
            "https://drive.google.com/file/d/1Nr0hx81t80sC8to2GPoUMzQ9V-IyLzpK/view?usp=sharing", // Lesson_06_03
            "https://drive.google.com/file/d/1BpFuOPKRzIqR08U1q87xj7MDoOFBcw8a/view?usp=sharing", // Lesson_06_04
            "https://drive.google.com/file/d/1hlAUbzZsvcQ1r0NIVP4GbRmpUzB8v6zN/view?usp=sharing", // Lesson_06_05
            "https://drive.google.com/file/d/1n0n6Fnx1HecreeW5ZdS75_3pTOIqPfUN/view?usp=sharing", // Lesson_06_06
            "https://drive.google.com/file/d/1psogeddkqPmKO5rwjv-lzFg6kIoAVZVi/view?usp=sharing", // Lesson_06_07
            "https://drive.google.com/file/d/1AXebECyT6oqXhyCRd1R5piFgBF1boUM8/view?usp=sharing", // Lesson_06_08
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Lesson06_01(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson06_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Lesson06_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
        private void Tapped_Lesson06_04(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }
        private void Tapped_Lesson06_05(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[5]);
        }
        private void Tapped_Lesson06_06(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[6]);
        }
        private void Tapped_Lesson06_07(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[7]);
        }
        private void Tapped_Lesson06_08(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
    }
}