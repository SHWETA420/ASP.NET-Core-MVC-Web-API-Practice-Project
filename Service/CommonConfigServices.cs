using Microsoft.Extensions.DependencyInjection;
using Service.Class;
using Service.IClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class CommonConfigServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //Register Repository dependency
            services.AddScoped<IUsersService, UsersService>();
        }
    }
}
