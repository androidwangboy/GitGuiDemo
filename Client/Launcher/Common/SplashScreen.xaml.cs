using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Augmentum.Gaming.Launcher.Common
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            Task.Factory.StartNew(() =>
            {
                var mainWindowLoaded = false;

                do
                {
                    Dispatcher.BeginInvoke((Action)(() =>
                    {
                        mainWindowLoaded = (null != Application.Current
                            && null != Application.Current.MainWindow
                            && Application.Current.MainWindow.IsLoaded);
                    }), DispatcherPriority.Background);

                    Thread.Sleep(100);
                } while (!mainWindowLoaded);

                Dispatcher.BeginInvoke((Action)(() =>
                {
                    Close();
                }), DispatcherPriority.Background);
            });

            InitializeComponent();

            splashImage.Source = new BitmapImage(new Uri("Icons/SplashPage.png", UriKind.Relative));
        }
    }
}
