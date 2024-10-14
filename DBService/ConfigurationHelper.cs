using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBService
{
    public static class ConfigurationHelper
    {
        public static IConfiguration GetConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Current Directory
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            return configuration;
        }
    }
}
