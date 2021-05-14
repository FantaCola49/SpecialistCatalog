using SpecialistCatalog.Models;
using SpecialistCatalog.ViewModels;
using SpecialistCatalog.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AISnaGT_items : ContentPage
    {
        AISItemsViewModel _viewModel;
        public AISnaGT_items()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AISItemsViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}