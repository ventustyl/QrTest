using Microsoft.Extensions.DependencyInjection;
using QrTest.Pages;
using QrTest.ViewModels;
using Xunit;

namespace QrTest.Tests;

public class ScanPageTests
{
    [Fact]
    public void Container_resolves_scan_page_with_viewmodel()
    {
        var app = QrTest.MauiProgram.CreateMauiApp();
        using var scope = app.Services.CreateScope();
        var page = scope.ServiceProvider.GetService<ScanPage>();

        Assert.NotNull(page);
        Assert.IsType<ScanViewModel>(page.BindingContext);
    }
}

