using System.IO;

using Android.Content;

using Tracing;

namespace CrossPlatformLibrary.WebBrowser
{
    public class WebBrowser : WebBrowserBase
    {
        public WebBrowser(ITracer tracer)
            : base(tracer)
        {
        }

        protected override void OnOpenUrl(string url)
        {
            string application = null;
            var extension = Path.GetExtension(url);
            if (extension != null)
            {
                switch (extension.ToLower())
                {
                    case ".doc":
                    case ".docx":
                        application = "application/msword";
                        break;
                    case ".pdf":
                        application = "application/pdf";
                        break;
                    case ".xls":
                    case ".xlsx":
                        application = "application/vnd.ms-excel";
                        break;
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                        application = "image/jpeg";
                        break;
                    default:
                        application = "*/*";
                        break;
                }
            }

            var uri = Android.Net.Uri.Parse(url);
            var intent = new Intent(Intent.ActionView);
            if (application != null)
            {
                intent.SetDataAndType(uri, application);
            }
            else
            {
                intent.SetData(uri);
            }

            intent.SetFlags(ActivityFlags.ClearWhenTaskReset | ActivityFlags.NewTask);
            ////intent.SetFlags(ActivityFlags.ClearTop);
            ////intent.SetFlags(ActivityFlags.NewTask);

            try
            {
                Android.App.Application.Context.StartActivity(intent);
            }
            catch (ActivityNotFoundException)
            {
                // Try again without application type:
                intent.SetType(null);
                Android.App.Application.Context.StartActivity(intent);
            }
        }
    }
}