﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace BTTP.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            OxyPlot.Xamarin.Forms.Platform.iOS.PlotViewRenderer.Init();
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
