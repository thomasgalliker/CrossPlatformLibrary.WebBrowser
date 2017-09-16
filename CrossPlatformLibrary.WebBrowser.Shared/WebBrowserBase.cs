using System;

using Guards;

using Tracing;

namespace CrossPlatformLibrary.WebBrowser
{
    public abstract class WebBrowserBase : IWebBrowser
    {
        private readonly ITracer tracer;

        protected WebBrowserBase(ITracer tracer)
        {
            Guard.ArgumentNotNull(tracer, nameof(tracer));

            this.tracer = tracer;
        }

        public void OpenUrl(string url)
        {
            Guard.ArgumentNotNullOrEmpty(url, nameof(url));

            try
            {
                this.OnOpenUrl(url);
            }
            catch (Exception ex)
            {
                this.tracer.Exception(ex, $"Failed to OpenUrl with url={url}");
            }
        }

        protected abstract void OnOpenUrl(string url);
    }
}