using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialistCatalog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialistCatalog.Views.ITPRIS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ITPRIS_Labs : ContentPage
    {
        ITPRISLabsViewModel _viewModel;
        public ITPRIS_Labs()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ITPRISLabsViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}