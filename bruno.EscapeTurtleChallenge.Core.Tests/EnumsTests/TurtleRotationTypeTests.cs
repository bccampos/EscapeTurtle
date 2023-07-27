using bruno.EscapeTurtleChallenge.Core.Enums;

namespace bruno.EscapeTurtleChallenge.Core.Tests.EnumsTests
{
    public class TurtleRotationTypeTests
    {
        private const int _expectedTurtleRotationNumber = 4;
        [Fact]
        public void Rotation_ShouldHaveOnlyTwoTypes()
        {
            int count = Enum.GetValues(typeof(TurtleRotationType)).Length;
            Assert.Equal(_expectedTurtleRotationNumber, count);
        }
    }
}
