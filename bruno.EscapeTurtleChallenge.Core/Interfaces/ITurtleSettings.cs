using bruno.EscapeTurtleChallenge.Core.Domain;
using System;

namespace bruno.EscapeTurtleChallenge.Core.Interfaces
{
    public interface ITurtleSettings
    {
        int Width { get; }

        int Height { get; }

        ExitPosition ExitPosition { get; }

        Turtle Turtle { get; }

        Mine[] Mines { get; }        
    }
}