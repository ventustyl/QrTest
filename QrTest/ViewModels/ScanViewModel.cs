using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QrTest.Services;

namespace QrTest.ViewModels;

public partial class ScanViewModel : ObservableObject
{
    private readonly IApplicationService _svc;

    public ScanViewModel(IApplicationService svc)
    {
        _svc = svc;
    }

    // Commande déclenchée par la page
    [RelayCommand]
    public async Task HandleQrAsync(string payload)
    {
        // Ici vous décidez quoi faire du contenu QR
        await _svc.ProcessQrAsync(payload);
    }
}

public interface IApplicationService
{
    Task ProcessQrAsync(string payload);
}
