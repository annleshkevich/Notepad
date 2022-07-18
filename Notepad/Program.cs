using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Notepad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreatWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
