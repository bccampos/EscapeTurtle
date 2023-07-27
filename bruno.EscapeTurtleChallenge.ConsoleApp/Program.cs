// See https://aka.ms/new-console-template for more information
using bruno.EscapeTurtleChallenge.ConsoleApp.Settings;
using bruno.EscapeTurtleChallenge.Core.Enums;
using bruno.EscapeTurtleChallenge.Core.Interfaces;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Reflection;

namespace bruno.EscapeTurtleChallenge.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting new escape Turtle Challenge");

            Parser.Default.ParseArguments<FileSettings>(args)
                .WithParsed(options => Init(options));
        }

        private static void Init(FileSettings files)
        {
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var turtleSettingsFile = Path.Combine(directory, files.TurtleSettings);
            var movesFile = Path.Combine(directory, files.Moves);

            if (!File.Exists(turtleSettingsFile))
            {
                Console.WriteLine("Turtle settings file does not exists.");
                return;
            }

            if (!File.Exists(movesFile))
            {
                Console.WriteLine("Moves file does not exists.");
                return;
            }

            ITurtleSettings settings = LoadSettings(turtleSettingsFile);
            IEnumerable<TurtleActionType> moves = LoadMoves(movesFile);

            var serviceProvider = Startup.ConfigureServices();
            var turtleGame = serviceProvider.GetRequiredService<ITurtleGame>();
            turtleGame.CreateTurtleGame(settings, moves);
            turtleGame.Start();
        }

        private static ITurtleSettings LoadSettings(string settingsFile)
        {
            var settings = JsonConvert.DeserializeObject<TurtleSettings>(File.ReadAllText(settingsFile));

            return settings;
        }

        private static IEnumerable<TurtleActionType> LoadMoves(string movesFile)
        {
            List<TurtleActionType> actions = new List<TurtleActionType>();

            var contents = File.ReadAllText(movesFile);
            var entries = contents.Split(',');
            foreach (string entry in entries)
            {
                if (entry.ToUpper().Equals("M"))
                {
                    actions.Add(TurtleActionType.Move);
                    continue;
                }
                if (entry.ToUpper().Equals("R"))
                {
                    actions.Add(TurtleActionType.Rotate);
                }
            }

            return actions;
        }
    }   
}






