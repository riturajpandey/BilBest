using System;
using System.Collections.Generic;
using System.Text;
using BilBest.Providers;
using Autofac;

namespace BilBest.BusinessCode
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            ContainerBuilder cb = new ContainerBuilder();

            RegisterDepenencies(cb);

            return cb.Build();
        }

        protected virtual void RegisterDepenencies(ContainerBuilder cb)
        {
            // Services
            GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.Register<IApiProvider, ApiProvider>();
            //// View Models
            GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.Register<IBusinessCode, BuisnessCode>();
        }
    }
}
