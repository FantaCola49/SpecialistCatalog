using SpecialistCatalog.Models;
using SpecialistCatalog.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using SpecialistCatalog.Services;

namespace SpecialistCatalog.ViewModels
{
    public class SIIMaterialsViewModel : BaseViewModel
    {
        private Item _selectedItem;
        OpenInBrowser inBrowser;
        public ObservableCollection<Item> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }
        public SIIMaterialsViewModel()
        {
            Title = "Лекции СИИ";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<Item>(OnItemSelected);
            inBrowser = new OpenInBrowser();
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    if (item.Is_SIILection)
                        Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        void OnItemSelected(Item item)
        {
            if (item == null)
                return;
            inBrowser.OpenBrowser(item.Link.ToString());
        }
    }
}
