using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
