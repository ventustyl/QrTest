using Microsoft.Maui.ApplicationModel;
using ZXing.Net.Maui;
using QrTest.ViewModels;

namespace QrTest.Pages
{
    public partial class ScanPage : ContentPage
    {
        private readonly ScanViewModel _vm;
        public ScanPage(ScanViewModel vm)
        {
            InitializeComponent();
            BindingContext = _vm = vm;
        }

        void OnDetected(object sender, BarcodeDetectionEventArgs e)
        {
            // 1. Filtrer : on ne garde que les QR Code
            var qr = e.Results.FirstOrDefault(r => r.Format == BarcodeFormat.QrCode);
            if (qr is null) return;

            // 2. Basculer côté UI principal
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                Scanner.IsDetecting = false;
                await _vm.HandleQrAsync(qr.Value);
                await Shell.Current.GoToAsync("..");
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Exemple : naccepter que le QR Code, activer lauto-rotation
            Scanner.Options = new BarcodeReaderOptions
            {
                Formats = BarcodeFormat.QrCode,
                AutoRotate = true
            };

            Scanner.IsDetecting = true;
        }

        protected override void OnDisappearing()
        {
            Scanner.IsDetecting = false;
            base.OnDisappearing();
        }
    }
}
