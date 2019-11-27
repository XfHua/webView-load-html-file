using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using WebKit;
using WorkingWithWebview;
using WorkingWithWebview.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(myWeb), typeof(MyWebRenderer))]
namespace WorkingWithWebview.iOS
{
    public class MyWebRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            //this.MediaPlaybackRequiresUserAction = false;
        }
    }
}