using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAdd
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IDateAddService, DateAddService>()
                .AddSingleton<IManipulateDateService, ManipulateDateService>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
