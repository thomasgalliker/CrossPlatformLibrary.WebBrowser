using CrossPlatformLibrary.IoC;

namespace CrossPlatformLibrary.WebBrowser
{
    public class ContainerExtension : IContainerExtension
    {
        public void Initialize(ISimpleIoc container)
        {
            container.RegisterWithConvention<IWebBrowser>();
        }
    }
}
