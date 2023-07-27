using CommandLine.Text;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.ConsoleApp.Settings
{
    public class FileSettings
    {
        [Option('t', Default = "turtle-settings.json", Required = true, HelpText = "Turtle settings file is not valid.")]
        public string TurtleSettings { get; set; }

        [Option('m', Default = "moves.json", Required = true, HelpText = "Moves file is not not valid.")]
        public string Moves { get; set; }
    }
}
