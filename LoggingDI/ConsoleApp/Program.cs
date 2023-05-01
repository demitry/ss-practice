using Autofac;
using CommonLibrary;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Autofac container.
            var builder = new ContainerBuilder();

            // The type Cat is added to container so that the container
            // would be able to provide instances of it.
            builder.RegisterType<Cat>();

            // Create Logger<T> when ILogger<T> is required.
            builder.RegisterGeneric(typeof(Logger<>))
                .As(typeof(ILogger<>));

            // Use NLogLoggerFactory as a factory required by Logger<T>.
            builder.RegisterType<NLogLoggerFactory>()
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            // Finish registrations and prepare the container that can resolve things.
            var container = builder.Build();

            // Entry point. This provides our logger instance to a Cat's constructor.
            Cat cat = container.Resolve<Cat>();

            // Run.
            string result = cat.MakeSound();
            Console.WriteLine(result);
            
            Console.ReadKey();

            /*
              Here are the detailed mechanics of what happens when we call container.Resolve<Cat>().
              Autofac found the Cat’s constructor argument ILogger<Cat>.
              To resolve it, it had to, according to our registration, create an instance of Logger<Cat>.
              But the Logger<T> class has the constructor that accepts some ILoggerFactory (src). So now Autofac needed to create an instance of the factory.
              We had registered NLog’s NLogLoggerFactory (src) as the implementation of this interface. So Autofac then created a NLogLoggerFactory (and kept it for future usages, thanks to InstancePerLifetimeScope() call), and used it to instantiate a Logger<Cat>. 
              The created logger was then passed to Cat’s constructor.
              The consumer only had to request a Cat - no specific knowledge of loggers was needed.
             */
        }
    }
}
