using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)//over boşluk load
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();//Bu kod derki eğer ki birisi senden IProdcutService isterse ProduxtManager ver.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

        }
    }
}
