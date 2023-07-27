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
    public class TurtleHelperDataTests
    {
        public static IEnumerable<object[]> DataRotate()
        {
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Rotate }, TurtleRotationType.East };
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Rotate, TurtleActionType.Rotate, TurtleActionType.Rotate }, TurtleRotationType.West };
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Rotate, TurtleActionType.Rotate, TurtleActionType.Rotate, TurtleActionType.Rotate }, TurtleRotationType.North };
        }

        public static IEnumerable<object[]> DataMove()
        {
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Move }, new Position(0, 0) };
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Move, TurtleActionType.Rotate, TurtleActionType.Move, TurtleActionType.Move }, new Position(2, 0) };
        }

        public static IEnumerable<object[]> DataDead()
        {
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Rotate, TurtleActionType.Move } };
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Move, TurtleActionType.Rotate, TurtleActionType.Move,
                                                                     TurtleActionType.Move, TurtleActionType.Move, TurtleActionType.Rotate,
                                                                     TurtleActionType.Move} };
        }

        public static IEnumerable<object[]> DataExited()
        {
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Move, TurtleActionType.Rotate, TurtleActionType.Move,
                                                                     TurtleActionType.Move, TurtleActionType.Move, TurtleActionType.Move,
                                                                     TurtleActionType.Rotate, TurtleActionType.Move, TurtleActionType.Move} };
        }

        public static IEnumerable<object[]> DataEscape()
        {
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Move, TurtleActionType.Rotate, TurtleActionType.Move,
                                                                     TurtleActionType.Move, TurtleActionType.Rotate, TurtleActionType.Move,
                                                                     TurtleActionType.Move, TurtleActionType.Rotate, TurtleActionType.Rotate,
                                                                     TurtleActionType.Rotate, TurtleActionType.Move, TurtleActionType.Move} };
        }

        public static IEnumerable<object[]> DataRotateEast()
        {
            yield return new object[] { new List<TurtleActionType> { TurtleActionType.Rotate, TurtleActionType.Rotate } };
        }
    }
}
