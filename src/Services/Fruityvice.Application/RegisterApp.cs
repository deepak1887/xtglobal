using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Fruityvice.Application;
public static class RegisterApp
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
