using AspNetCore.Lab.DiMw.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Lab.DiMw.CustomMiddleWare
{
    public class MiddleWareExample
    {
        private readonly RequestDelegate _next;
     
        public MiddleWareExample(RequestDelegate next)
        {
            _next = next;
            
        }

        public async Task Invoke(HttpContext httpContext, ICounterService counterService)
        {
            counterService.Increment();
            await _next.Invoke(httpContext);
        }

    }
}
