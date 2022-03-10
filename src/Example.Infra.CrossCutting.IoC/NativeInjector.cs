using Example.Application.ExampleService.Service;
using Example.Infra.CrossCutting.IoC.Settings;
using Example.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Infra.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void Setup(IServiceCollection services, IConfiguration configuration)
        {
            RegisterServices(services, configuration);
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

        }
    }
}
