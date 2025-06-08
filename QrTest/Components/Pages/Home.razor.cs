namespace QrTest.Components.Pages
{
    public partial class Home
    {
        /// <summary>
        /// Ouvre la page native de scan.
        /// Le Dispatcher garantit l�ex�cution sur le thread UI MAUI.
        /// </summary>
        private void OpenScanner()
        {
            Dispatcher.Dispatch(async () =>
            {
                // Navigation Shell d�clarative
                await Shell.Current.GoToAsync(nameof(QrTest.Pages.ScanPage));
            });
        }
    }
}