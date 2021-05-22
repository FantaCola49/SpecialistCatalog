using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views.SII
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SII_Labs : ContentPage
    {
        SIILabsViewModel _viewModel;
        public SII_Labs()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SIILabsViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}