using Xunit;

namespace TestHelpers.ContextBaseContext
{
    public class WhenDisposingContextBase : ContextBaseContext
    {
        public override void When()
        {
            Dispose( );
        }

        [Fact]
        public void ShouldCleanUp()
        {
            Assert.True( cleanUpExecuted );
        }
    }
}