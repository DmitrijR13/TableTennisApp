using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace WebApi.Infrastructure
{
    public class NinjectControllerFactory 
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            // создание контейнера       
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
       
        private void AddBindings()
        {
            //ninjectKernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }
    }

}