using NavModule.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using DryIoc;
using Prism.DryIoc;

namespace NavModule
{
    public class NavModuleModule : IModule
    {
        private IRegionManager _regionManager;
        private IContainer _container;

        public NavModuleModule(IContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<ViewA>();
        }
    }
}