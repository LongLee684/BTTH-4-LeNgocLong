using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Extensions.DependencyInjection;

namespace ProductService.Implementation
{
    public static class MediatRConfig
    {
        public static void AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(MediatRConfig).Assembly));
        }
    }
}
