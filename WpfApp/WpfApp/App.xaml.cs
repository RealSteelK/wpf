using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media.Animation;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Prism.Unity.PrismApplication
    { 
        protected override Window CreateShell()
        {
            //Return your main window here
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Register your services and views here
            containerRegistry.RegisterForNavigation<MainWindow>();
        }
    }

}
