using System;
using System.Collections.Generic;

namespace RabbitVerse.Consuming.AspNetCore
{
    internal class AspNetCoreProvider
    {
        private readonly IServiceProvider _serviceProvider;


        public AspNetCoreProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}