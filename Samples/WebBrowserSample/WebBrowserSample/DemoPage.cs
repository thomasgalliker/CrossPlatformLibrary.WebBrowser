using CrossPlatformLibrary.IoC;
using CrossPlatformLibrary.WebBrowser;

using Xamarin.Forms;

namespace WebBrowserSample
{
    class DemoPage : ContentPage
    {
        public DemoPage()
        {
            var urlEntry = new Entry { Text = "http://www.thomasgalliker.ch" };
            var navigateButton = new Button
            {
                Text = "Click to navigate"
            };
            navigateButton.Clicked += (sender, args) =>
            {
                IWebBrowser webBrowser = SimpleIoc.Default.GetInstance<IWebBrowser>();
                webBrowser.OpenUrl(urlEntry.Text);
            };

            var stackPanel = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { urlEntry, navigateButton }
            };

            this.Content = stackPanel;
        }
    }
}
