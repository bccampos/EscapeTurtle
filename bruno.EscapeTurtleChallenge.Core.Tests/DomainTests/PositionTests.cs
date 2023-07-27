using bruno.EscapeTurtleChallenge.Core.Domain;

namespace bruno.EscapeTurtleChallenge.Core.Tests.DomainTests
{
    public class PositionTests
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        [InlineData(1, 2)]
        public void Constructor_ShouldSetProperties_FromParameters(int x, int y)
        {
            Position position = new Position(x, y);

            Assert.Equal(x, position.X);
            Assert.Equal(y, position.Y);
        }
    }
}
