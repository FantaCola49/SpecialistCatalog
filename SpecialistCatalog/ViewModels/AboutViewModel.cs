using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SpecialistCatalog.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://drive.google.com/file/d/1Map-wtpPi8-R9qel3fYzNoot7BTRS8He/view?usp=sharing"));
        }

        public void OpenFile(string FileName, string FileLink)
        {
            Title = $"{FileName}";
            var command = new Command(async () => await Browser.OpenAsync("https://drive.google.com/file/d/1Map-wtpPi8-R9qel3fYzNoot7BTRS8He/view?usp=sharing"));
        }

        public ICommand OpenWebCommand { get; }
    }
}