# QrTest

QrTest is a minimal multi-platform application built with **.NET MAUI**. It demonstrates using **ZXing.Net.Maui** for QR code scanning and integrates a Blazor web view for UI components. The project targets Android, iOS, macOS (Mac Catalyst) and Windows.

## Prerequisites

- [.NET](https://dotnet.microsoft.com/) 9 SDK with the MAUI workload installed.
  - To install the MAUI workload:
    ```bash
    dotnet workload install maui
    ```
- Platform-specific dependencies for running MAUI apps (Android SDKs, Xcode for iOS/macOS or Windows SDKs).

## Building the project

Clone the repository and run the build from the repository root:

```bash
# Restore and build all projects
 dotnet build QrTest.sln
```

## Running

Run the application for a specific target. Example for Android:

```bash
dotnet build QrTest -t:Run -f net9.0-android
```

Other platforms can be specified using the appropriate target framework (e.g., `net9.0-windows`, `net9.0-ios`, `net9.0-maccatalyst`). You can also open the solution in Visual Studio to run and debug.

## Notes

ZXing.Net.Maui provides the camera barcode reader used on the `ScanPage`. Ensure camera permissions are enabled on your device/emulator.

