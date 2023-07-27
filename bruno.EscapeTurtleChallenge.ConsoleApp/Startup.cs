using bruno.EscapeTurtleChallenge.ConsoleApp.Settings;
using bruno.EscapeTurtleChallenge.Core;
using bruno.EscapeTurtleChallenge.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace bruno.EscapeTurtleChallenge.ConsoleApp
{
    public class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IConsole, ConsoleWrapper>(); 
            services.AddSingleton<ITurtleSettings, TurtleSettings>(); 
          
            services.AddSingleton<ITurtleGame, TurtleGame>();

            return services.BuildServiceProvider();
        }
    }
}
