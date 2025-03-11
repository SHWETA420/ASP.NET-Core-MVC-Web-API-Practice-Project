using Microsoft.Extensions.DependencyInjection;
using Repository.Class;
using Repository.IClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class CommonConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //Register Repository dependency
            services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
