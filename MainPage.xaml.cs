using Plugin.Media;
using Plugin.Media.Abstractions;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpenCameraClicked(object sender, EventArgs e)
        {
            try
            {
                // settings for the camera
                var options = new StoreCameraMediaOptions { CompressionQuality = 50 };
                // Launch the camera app
                var result = await CrossMedia.Current.TakePhotoAsync(options);
            }
            catch (Exception ex)
            {
                // Handle exception or display an error message
                await DisplayAlert("Error", $"Unable to open camera app: {ex.Message}", "OK");
            }
        }
    }

}
