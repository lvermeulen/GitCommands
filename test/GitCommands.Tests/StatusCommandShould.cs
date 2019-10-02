using Xunit;

namespace GitCommands.Tests
{
    public class StatusCommandShould
    {
        [Theory]
        [InlineData(@"C:\tuirepo\Insurance.Claims", false)]
        [InlineData(@"C:\tuirepo\Insurance.Product", true)]
        public void Execute(string path, bool expectedResult)
        {
            var command = new StatusCommand();
            Assert.Equal(expectedResult, command.Execute(path));
        }
    }
}
