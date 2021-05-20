using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.Views.UP_Labs.Lab6MSProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _6_7DetailPage : ContentPage
    {
        OpenInBrowser inBrowser;
        public _6_7DetailPage()
        {
            InitializeComponent();
            inBrowser = new OpenInBrowser();
            WebViewContainer.Source = links[0];
        }
        readonly string[] links = new string[]
        {
            "https://drive.google.com/file/d/1pslBvegGGMjJX8Iv84mHX1KESfjG70En/view?usp=sharing", // Лекция о практической работе 7

            "https://drive.google.com/file/d/1AOYfvlCzzeHC4uDLb91Ga7izVPOgys6s/view?usp=sharing", // Lesson_07_01
            "https://drive.google.com/file/d/1chGYMxbV4YsdWMGuh0FK0GSGUovpqIbn/view?usp=sharing", // Lesson_07_02
            "https://drive.google.com/file/d/1lJHJNNUSyQqCtXi-XnTrb2lVVeeFSjq6/view?usp=sharing", // Lesson_07_03
            "https://drive.google.com/file/d/17H7TP5elwXOn2hh0ZY5rXLhVSiF8lJ78/view?usp=sharing", // Lesson_07_04
            "https://drive.google.com/file/d/1kFNjSJ5d-0L2BEFuQR6GK2Q8QrL3EYTW/view?usp=sharing", // Lesson_07_05
            "https://drive.google.com/file/d/1e4f747rK2yg_vH-2fXH5f1AQKKZgqIVg/view?usp=sharing", // Lesson_07_06
            "https://drive.google.com/file/d/1nqK1YHYZyb3K2XJU8OWIvtA7rxqj_QZn/view?usp=sharing", // Lesson_07_07
            "https://drive.google.com/file/d/1cFLIrB-l7-lpTFFYarw10Zl9VnxQhy0Q/view?usp=sharing", // Lesson_07_08
            "https://drive.google.com/file/d/15BtbqDp4VLTLS-m61q8G-DH6hWdbr8_v/view?usp=sharing", // Lesson_07_09
            "https://drive.google.com/file/d/1iBr5Ay_yDznrB3SaELyhQrbkEIIh7y_M/view?usp=sharing", // Lesson_07_10
            "https://drive.google.com/file/d/1aX5Aji74Hh1omxZjHL2TQmrkMuHyretS/view?usp=sharing", // Lesson_07_11
            "https://drive.google.com/file/d/1Lgn4jXrBg-2pfFu0tDfi1GxxBpUbjrj0/view?usp=sharing", // Lesson_07_12
            "https://drive.google.com/file/d/1VjyKsSXios8MQP-k1U_yjTTPY6TtLL5Q/view?usp=sharing" // Lesson_07_13
        };
        private void Button_Clicked(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[0]);
        }
        private void Tapped_Lesson07_01(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[1]);
        }
        private void Tapped_Lesson07_02(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[2]);
        }
        private void Tapped_Lesson07_03(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[3]);
        }
        private void Tapped_Lesson07_04(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[4]);
        }
        private void Tapped_Lesson07_05(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[5]);
        }
        private void Tapped_Lesson07_06(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[6]);
        }
        private void Tapped_Lesson07_07(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[7]);
        }
        private void Tapped_Lesson07_08(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
        private void Tapped_Lesson07_09(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
        private void Tapped_Lesson07_10(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
        private void Tapped_Lesson07_11(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
        private void Tapped_Lesson07_12(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
        private void Tapped_Lesson07_13(object sender, EventArgs e)
        {
            inBrowser.OpenBrowser(links[8]);
        }
    }
}