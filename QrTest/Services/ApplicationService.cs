using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using QrTest.ViewModels;


using QrTest.ViewModels;

namespace QrTest.Services
{
    internal class ApplicationService : IApplicationService
    {
        public Task ProcessQrAsync(string payload)
        {
            // Application-specific processing would occur here
            return Task.CompletedTask;
        }

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
