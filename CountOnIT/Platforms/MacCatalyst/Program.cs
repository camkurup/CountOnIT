using ObjCRuntime;
using UIKit;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace CountOnIT
{
    public class Program
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));

            var mauiApp = MauiProgram.CreateMauiApp();

            mauiApp.OnMauiContextCreated((context) =>
            {
                // Definér ønsket vinduesstørrelse
                var window = context.MauiContext.Window;
                window.SetSize(new Microsoft.Maui.Graphics.Size(800, 600));
            });

            return mauiApp.Run();
        }
    }
}
