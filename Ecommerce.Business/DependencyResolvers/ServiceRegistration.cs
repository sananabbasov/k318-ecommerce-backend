using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Business.Abstract;
using Ecommerce.Business.AutoMapper;
using Ecommerce.Business.Concrete;
using Ecommerce.Business.Consumers;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.DataAccess.Concrete.EntityFramework;
using Ecommerce.Entities.Commands;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Business.DependencyResolvers;

public static class ServiceRegistration
{
    public static void AddBusinesRegistration(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();

        var mapperConfig = new MapperConfiguration(mc =>
                    {
                        mc.AddProfile(new MappingProfile());
                    });
        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);




        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ICategoryService, CategoryManager>();

        services.AddScoped<IProductDal, EfProductDal>();
        services.AddScoped<IProductService, ProductManager>();


        services.AddScoped<IAuthService, AuthManager>();
        services.AddScoped<IUserDal, EfUserDal>();



 services.AddMassTransit(config =>
            {
                config.AddConsumer<SendEmailConsumer>();

                config.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host("amqp://guest:guest@localhost");
                    cfg.Message<SendEmailCommand>(x => x.SetEntityName("SendEmailCommand"));

                    cfg.ReceiveEndpoint("send-email-command", c =>
                    {
                        c.ConfigureConsumer<SendEmailConsumer>(ctx);
                    });
                });
            });

    }
}
