using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OmegaCom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarCodeScanner : ContentPage
    {

        public string subjectOfEmail = "000";
        public string sb = "123";
        public BarCodeScanner()
        {
            InitializeComponent();
            

   

        }

         void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            
            
            
            Device.BeginInvokeOnMainThread(() =>
                 {
                     scanResultText.Text = result.Text;
                     

                 });


     
          
          


        }

        void Swap(string input, ref string otherinput)
        {
            otherinput = input;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            Swap(scanResultText.Text, ref subjectOfEmail);

            
            await Navigation.PushModalAsync(new NavigationPage(new ImagesToSend(subjectOfEmail)));
           
        }
    }
}