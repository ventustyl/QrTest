using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using QrTest.ViewModels;

namespace QrTest.Services;

public class ApplicationService : IApplicationService
{
    private readonly IList<string> _payloads = new List<string>();

    public IReadOnlyList<string> Payloads => _payloads.ToList();

    public Task ProcessQrAsync(string payload)
    {
        _payloads.Add(payload);
        Debug.WriteLine($"QR payload processed: {payload}");
        return Task.CompletedTask;
    }
}
