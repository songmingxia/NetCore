using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace helloworld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder().UseKestrel()
                .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://localhost:8888")
                .Build()
                .Run();
        }
    }
}
