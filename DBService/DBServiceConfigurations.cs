using DBService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBService
{
    public class DBServiceConfigurations
    {
        public static void ExecuteDbServiceConfigurations(IServiceCollection services)
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            services.AddDbContext<AppdbContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
