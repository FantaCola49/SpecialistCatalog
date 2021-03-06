using SpecialistCatalog.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpecialistCatalog.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    class AISItemsDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string link;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string Link
        {
            get => link;
            set => SetProperty(ref link, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Link = item.Link;

            }
            catch (Exception)
            {
                Debug.WriteLine("Не получилось загрузить страницу");
            }
        }
    }
}
