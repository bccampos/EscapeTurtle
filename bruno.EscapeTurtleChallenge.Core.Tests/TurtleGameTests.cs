using bruno.EscapeTurtleChallenge.Core.Enums;
using bruno.EscapeTurtleChallenge.Core.Tests.Helper;
using NSubstitute;

namespace bruno.EscapeTurtleChallenge.Core.Tests
{
    public class TurtleGameTests : TurtleHelperTests
    {
        [Theory, MemberData(nameof(TurtleHelperDataTests.DataExited), MemberType = typeof(TurtleHelperDataTests))]
        public void MoveTurtleAcrossMap_ShouldGetEscapeMessage(List<TurtleActionType> movesList)
        {
            var game = MakeTurtleGame(movesList);
            game.Start();

            _console.Received().WriteLine("Turtle has escaped sucefully. Congratulations!! ");
        }

        [Theory, MemberData(nameof(TurtleHelperDataTests.DataRotateEast), MemberType = typeof(TurtleHelperDataTests))]
        public void MoveTurtleAcrossMap_ShouldGetRotatedMessageEast(List<TurtleActionType> movesList)
        {
            var game = MakeTurtleGame(movesList);
            game.Start();

            _console.Received().WriteLine($"Turtle rotated {TurtleRotationType.East}");
        }

        [Fact]
        public void TurtleSettings_IsNull_ShouldGetErrorMessage()
        {
            var game = new TurtleGame(_console);
            game.CreateTurtleGame(null, null);
            game.Start();

            _console.Received().WriteLine("Before start the game you have to set the turtle settings.");
        }

        [Fact]
        public void Moves_IsNull_ShouldGetErrorMessage()
        {
            var game = MakeTurtleGame(null);
            game.Start();

            _console.Received().WriteLine("Before start the game you have to set the moves file.");
        }
    }
}