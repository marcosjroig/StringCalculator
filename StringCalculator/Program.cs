using System;
using Microsoft.Extensions.DependencyInjection;
using StringCalculator.Calculations;
using StringCalculator.Configuration;
using StringCalculator.Exceptions;
using StringCalculator.Ignore;
using StringCalculator.Numbers;
using StringCalculator.Validators;

namespace StringCalculator
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            //Register services
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            
            // Run console application main class
            scope.ServiceProvider.GetRequiredService<ConsoleApplication>().Run();
            
            // Dispose Services
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            
            services.AddScoped<ConsoleApplication>();
            services.AddScoped<IConfigurationReader, ConfigurationReader>();
            services.AddScoped<INumberParser, NumberParser>();
            services.AddScoped<IStringValidator, StringValidator>();
            services.AddScoped<ICalculation, Calculation>();
            services.AddScoped<ICalculator, Calculator>();
            services.AddScoped<ISum, Sum>();
            services.AddScoped<IParsingExceptions, ParsingExceptions>();
            services.AddScoped<IIgnoreNumbers, IgnoreNumbers>();

            _serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
