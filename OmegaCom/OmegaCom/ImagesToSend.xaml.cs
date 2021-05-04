using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.IO.Compression;
using System.Drawing;
using Android.Graphics;
using Bitmap = Android.Graphics.Bitmap;
using Image = Xamarin.Forms.Image;

namespace OmegaCom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


   
    public partial class ImagesToSend : ContentPage
    {

        public string sub = "123";
        List<String> imageList = new List<String>();

        public ImagesToSend(string subject)
        {
            InitializeComponent();

            BindingContext = subject;
            string s = subject;
            Swap(s, ref sub);
            labellabel.Text = s;
          
           
        }

        public void Swap(string subject, ref string sub)
        {
            sub = subject;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            


            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                Name = "image1.jpg",
                CompressionQuality = 40

            });
            
            imageButton0.Source = ImageSource.FromStream(() =>
            {
                
                var stream = file.GetStream();
                //file.Dispose();
                
                return stream;
                
            });

            imageList.Add(file.Path);

        }



        async void Button_Clicked1(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
               
                Name = "image2.jpg",
                CompressionQuality = 40

            });

            imageButton1.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
               
                
                return stream;
            });

            imageList.Add(file.Path);
        }


        async void Button_Clicked2(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
             
                Name = "image3.jpg",
                CompressionQuality = 40

            });

            imageButton2.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
               
                return stream;
            });

            imageList.Add(file.Path);
        }

        async void Button_Clicked3(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                
                Name = "image4.jpg",
                CompressionQuality = 40

            });

            imageButton3.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
                
                return stream;
            });
            imageList.Add(file.Path);
        }

        async void Button_Clicked4(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
           
            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                
                Name = "image5.jpg",
                CompressionQuality = 40

            });

            imageButton4.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
                
                return stream;
            });
            imageList.Add(file.Path);
        }

        async void Button_Clicked5(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
          
                Name = "image6.jpg",
                CompressionQuality = 40

            });

            imageButton5.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
               
                return stream;
            });

            imageList.Add(file.Path);
        }

        async void Button_Clicked6(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
               
                Name = "image7.jpg",
                CompressionQuality = 40

            });

            imageButton6.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
               
                return stream;
            });

            imageList.Add(file.Path);
        }

        async void Button_Clicked7(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
               
                Name = "image8.jpg",
                CompressionQuality = 40

            }); 

            imageButton7.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
                
                return stream;
            });

            imageList.Add(file.Path);


        }

           async void Button_Clicked_Send(object sender, EventArgs e)
        {
           
            List<String> list = new List<string>();
            list.Add("shippment@omegacom.at");

            string sbm = labellabel.Text;
            var message = new EmailMessage
            {

                
                Subject = labellabel.Text,
                Body = "Mit freundlichen Grüßen",
                To = list
            };

            
           

            foreach (String item in imageList)
            {
                message.Attachments.Add(new EmailAttachment(item));
            }
            

            await Email.ComposeAsync(message);


        }


        //public bool QuickZip(string[] filesToZip, string destinationZipFullPath)
        //{
        //    try
        //    {
        //        // Delete existing zip file if exists
        //        if (File.Exists(destinationZipFullPath))
        //            File.Delete(destinationZipFullPath);

        //        using (ZipArchive zip = ZipFile.Open(destinationZipFullPath, ZipArchiveMode.Create))
        //        {
        //            foreach (var file in filesToZip)
        //            {
        //                zip.CreateEntryFromFile(file, System.IO.Path.GetFileName(file), CompressionLevel.Optimal);
        //            }
        //        }

        //        return File.Exists(destinationZipFullPath);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Exception: {e.Message}");
        //        return false;
        //    }
        //}



    }


}