using SpecialistCatalog.Services;
using SpecialistCatalog.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //Здесь регистрируем классы-Services, в которых хранятся данные и списки о итемах. Items появляются в ItemsDetailPage и т.д.
            DependencyService.Register<MockDataStore>();
            //DependencyService.Register<AISDataStore>();
            //Походу, может быть только одно хранилище данных, бля(
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
