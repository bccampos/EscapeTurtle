using bruno.EscapeTurtleChallenge.Core.Domain;
using bruno.EscapeTurtleChallenge.Core.Enums;
using bruno.EscapeTurtleChallenge.Core.Interfaces;
using System;
using System.Xml.Linq;

namespace bruno.EscapeTurtleChallenge.Core
{
    public class TurtleGame : ITurtleGame
    {
        private ITurtleSettings _turtleSettings;
        private IEnumerable<TurtleActionType> _moves;
        private readonly IConsole _console;

        public int Width { get; set; }
        public int Height { get; set; }
        public Turtle Turtle { get; set; }
        public List<GameBase> GameBaseList { get; private set; } = new List<GameBase>();

        public TurtleGame(IConsole console)
        {
            _console = console;
        }

        public void CreateTurtleGame(ITurtleSettings turtleSettings, IEnumerable<TurtleActionType> moves)
        {
            _turtleSettings = turtleSettings;
            _moves = moves;
        }

        public void Start()
        {
            if (_turtleSettings is null)
            {
                _console.WriteLine("Before start the game you have to set the turtle settings.");
                return;
            }

            if (_moves is null || _moves.Count() == 0)
            {
                _console.WriteLine("Before start the game you have to set the moves file.");
                return;
            }

            LoadTurtleObject();

            foreach (var move in _moves)
            {
                switch (move)
                {
                    case TurtleActionType.Move:
                        HandleMoves();
                        break;
                    case TurtleActionType.Rotate:
                        Turtle.Rotate();
                        _console.WriteLine($"Turtle rotated {Turtle.Type}");
                        break;
                    default:
                        continue;
                }

                if (Turtle.IsDead)
                {
                    _console.WriteLine("Turtle has died!");
                }
                else if (Turtle.IsExitPosition)
                {
                    _console.WriteLine("Turtle has escaped sucefully. Congratulations!! ");
                }
            }
        }

        private void HandleMoves()
        {
            Turtle.Move();

            var response = Check(Turtle);
            if (response is not null)
            {
                response.Handle(_console, Turtle);

                if (Turtle.IsDead || Turtle.IsExitPosition)
                    return;
            }

            _console.WriteLine($"Turtle moved");
        }

        private GameBase Check(GameBase current)
        {
            return GameBaseList.FirstOrDefault(p => !object.ReferenceEquals(p, current) && p.Position == current.Position);
        }

        public void LoadTurtleObject()
        {
            Width = _turtleSettings.Width;
            Height = _turtleSettings.Height;

            Turtle = _turtleSettings.Turtle;

            GameBaseList.Add(_turtleSettings.Turtle);
            GameBaseList.Add(_turtleSettings.ExitPosition);

            LoadTurtlePositions();
        }

        private void LoadTurtlePositions()
        {
            foreach (var mine in _turtleSettings.Mines)
            {
                GameBaseList.Add(mine);
            }

            for (int i = 0; i < Width; ++i)
            {
                GameBaseList.Add(new Wall { Position = new Position(i, -1) });
                GameBaseList.Add(new Wall { Position = new Position(i, Height + 1) });
            }

            for (int i = 0; i < Height; ++i)
            {
                GameBaseList.Add(new Wall { Position = new Position(-1, i) });
                GameBaseList.Add(new Wall { Position = new Position(Width + 1, i) });
            }

        }

    }
}
