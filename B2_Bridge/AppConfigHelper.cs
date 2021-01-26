using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;

namespace B2_Bridge
{
    public class AppConfigHelper
    {
        public static IConfiguration config = null;

        static AppConfigHelper()
        {
            //注意 appsetting.json 属性 制到输出目录:始终复制
            config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .AddEnvironmentVariables()
            .Build();            
        }

        public static string GetImageFormatName()
        {
            string factoryName = null;
            try
            {
                factoryName = config["RefinedAbstraction"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetImageInstance()
        {
            string assemblyName = AppConfigHelper.GetImageFormatName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }

        public static string GetEnvName()
        {
            string factoryName = null;
            try
            {
                factoryName = config["ConcreteImplementor"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetEnvInstance()
        {
            string assemblyName = AppConfigHelper.GetEnvName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
