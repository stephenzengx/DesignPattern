﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;

namespace A2_Factory
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

        public static string GetSimpleAnimalType()
        {
            return config["AnimalType"];
        }

        public static string GetLoggerFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = config["LoggerFactory"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetLoggerFactoryInstance()
        {
            string assemblyName = GetLoggerFactoryName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }

        public static string GetSkinrFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = config["SkinFactory"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return factoryName;
        }

        public static object GetSkinFactoryInstance()
        {
            string assemblyName = GetSkinrFactoryName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}
