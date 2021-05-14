using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.XamarinFormsSaveOpenPDFPackage;

namespace SpecialistCatalog.Services
{
    public class WorkWithPDF
    {
        public async void SaveAndViewPDF(string Link, string FileName)
        {
            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync($@"{Link}");

            using (var memoryStream = new MemoryStream())
            {
                await stream.CopyToAsync(memoryStream);
                await CrossXamarinFormsSaveOpenPDFPackage.Current.SaveAndView($"{FileName}", "application/pdf", memoryStream, PDFOpenContext.ChooseApp);
            }

        }
    }
}
