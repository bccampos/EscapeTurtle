using Serilog.Core;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bruno.EscapeTurtleChallenge.Core.Interfaces;
using NSubstitute;
using bruno.EscapeTurtleChallenge.Core.Domain;
using bruno.EscapeTurtleChallenge.Core.Enums;

namespace bruno.EscapeTurtleChallenge.Core.Tests.Helper
{
    public class TurtleHelperTests
    {
        protected IConsole _console;

        protected TurtleHelperTests()
        {
            _console = Substitute.For<IConsole>();
        }

        public void Dispose()
        {
            
        }

        protected TurtleGame MakeTurtleGame(IEnumerable<TurtleActionType> moves)
        {
            var turtleSettings = MakeTurtleSettings();

            var game = new TurtleGame(_console);
            game.CreateTurtleGame(turtleSettings, moves);

            return game;
        }

        private ITurtleSettings MakeTurtleSettings()
        {
            var turtleSettings = Substitute.For<ITurtleSettings>();

            turtleSettings.Width.Returns(5);
            turtleSettings.Height.Returns(4);

            turtleSettings.Turtle.Returns(new Turtle
            {
                Position = new Position(0, 1),
                Type =  Enums.TurtleRotationType.North
            });

            turtleSettings.Mines.Returns(new Mine[]
            {
                new Mine { Position = new Position( 1, 1 ) },
                new Mine { Position = new Position( 3, 1 ) },
                new Mine { Position = new Position( 3, 3 ) }
            });

            turtleSettings.ExitPosition.Returns(new ExitPosition { Position = new Position(4, 2) });

            return turtleSettings;
        }
    }
}
