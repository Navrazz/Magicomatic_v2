using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Magicomatic.Views;
using Magicomatic.Modules.Collection;
using Magicomatic.Modules.Settings;
using Magicomatic.Modules.Decks;

namespace Magicomatic
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CollectionModule>();
            moduleCatalog.AddModule<DecksModule>();
            moduleCatalog.AddModule<SettingsModule>();
        }
    }
}
