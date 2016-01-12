# CrossPlatformLibrary.WebBrowser

### Download and Install CrossPlatformLibrary.WebBrowser
This library is available on NuGet: https://www.nuget.org/packages/CrossPlatformLibrary.WebBrowser/
Use the following command to install CrossPlatformLibrary.WebBrowser using NuGet package manager console:

    PM> Install-Package CrossPlatformLibrary.WebBrowser

You can use this library in any .Net project which is compatible to PCL (e.g. Xamarin Android, iOS, Windows Phone, Windows Store, Universal Apps, etc.)

### API Usage
CrossPlatformLibrary.WebBrowser provides a simple and platform-agnostic interface, ```IWebBrowser``` which can be used to open an URL in the web browser on the target platform:

```csharp
IWebBrowser webBrowser = new WebBrowser(); // Get instance from IoC container via dependency injection, if possible
webBrowser.OpenUrl("http://www.thomasgalliker.ch");
```

### License
This library is Copyright &copy; 2016 [Thomas Galliker](https://ch.linkedin.com/in/thomasgalliker). Free for non-commercial use. For commercial use please contact the author.

