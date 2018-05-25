using DisplayModule.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using DryIoc;
using Prism.DryIoc;

namespace DisplayModule
{
    public class DisplayModuleModule : IModule
    {
        private IRegionManager _regionManager;
        private IContainer _container;

        public DisplayModuleModule(IContainer container, IRegionManager regionManager)
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