using bruno.EscapeTurtleChallenge.Core.Domain;
using bruno.EscapeTurtleChallenge.Core.Interfaces;

namespace bruno.EscapeTurtleChallenge.ConsoleApp.Settings
{
    public class TurtleSettings : ITurtleSettings
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public ExitPosition ExitPosition { get; set; }

        public Turtle Turtle { get; set; }

        public Mine[] Mines { get; set; }
    }
}
