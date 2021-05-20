using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_5DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_5DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1x2RC_jVmGuXMbhM5zDRu4BjvA5GAStU3/view?usp=sharing", // Отчёт о практической работе 5

            "https://drive.google.com/file/d/1sGo52fMwy8ZO00gAgxOaoWHcIY_T-2hk/view?usp=sharing", // Lesson_05_01
            "https://drive.google.com/file/d/1wbTcwOTZx3v3SlUFdr7-efpW6lqr6q9U/view?usp=sharing", // Lesson_05_02
            "https://drive.google.com/file/d/1synMysSJB19aM6MP0UORjsg-iMTy_r2y/view?usp=sharing" // Lesson_05_03
        };
        private void Tapped_Lesson05_01(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson05_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Lesson05_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
    }
}