using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_3DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_3DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1FJtwwUeZRRILS_tBvuFo0TNJJcfzyysT/view?usp=sharing", //Отчёт по практической работе 3

            "https://drive.google.com/file/d/1SHnJHLIf2njZQxKDLz3ltJBMqbVUzVBY/view?usp=sharing", // Lesson_03_01.mpp
            "https://drive.google.com/file/d/1T8fb9eHebH7ZlD9znuInt-VoU-KFNLLf/view?usp=sharing", // Lesson_03_02.mpp
            "https://drive.google.com/file/d/1FRLG9j1FnLjlQoMgMzkrxFiaDexebHK0/view?usp=sharing", // Lesson_03_03.mpp
            "https://drive.google.com/file/d/1hAJ07ufspujgYq7n6V7nI1S2rzhhVsVD/view?usp=sharing", // Lesson_03_04.mpp
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Lesson03_01(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson03_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Lesson03_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
        private void Tapped_Lesson03_04(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }
    }
}