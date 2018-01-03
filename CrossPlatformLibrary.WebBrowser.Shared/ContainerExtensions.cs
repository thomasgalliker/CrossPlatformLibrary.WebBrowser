
using CrossPlatformLibrary.IoC;

namespace CrossPlatformLibrary.WebBrowser
{
    public class ContainerExtension : IContainerExtension
    {
        public void Initialize(IIocContainer container)
        {
            container.RegisterSingleton<IWebBrowser, WebBrowser>();
        }
    }
}
