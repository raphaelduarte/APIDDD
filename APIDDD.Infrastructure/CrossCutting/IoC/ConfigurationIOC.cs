using APIDDD.Application;
using APIDDD.Application.Interfaces;
using APIDDD.Domain.Core.Interfaces;
using APIDDD.Domain.Core.Services;
using APIDDD.Domain.Services;
using APIDDD.Infrastructure.CrossCutting.Interface;
using APIDDD.Infrastructure.CrossCutting.Mapper;
using APIDDD.Infrastructure.Data.Repositories;
using Autofac;

namespace APIDDD.Infrastructure.CrossCutting.IoC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationCustomerService>().As<IApplicationCustomerService>();
            builder.RegisterType<ApplicationProductService>().As<IApplicationProductService>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CustomerMapper>().As<ICustomerMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();

            #endregion
        }
    }
}
