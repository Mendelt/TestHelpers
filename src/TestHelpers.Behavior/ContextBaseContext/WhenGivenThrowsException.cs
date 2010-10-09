using System;
using Xunit;

namespace TestHelpers.ContextBaseContext
{
    public class WhenGivenThrowsException : ContextBaseContext
    {
        public class TestContext : ContextBase
        {
            public static bool testContextCleanUpExecuted;

            public override void Given()
            {
                throw new InvalidOperationException();
            }

            public override void CleanUp()
            {
                testContextCleanUpExecuted = true;
            }
        }

        [Fact]
        public void ShouldRethrowExceptionConstructing()
        {
            Assert.Throws<InvalidOperationException>( ( ) => new TestContext( ) );
        }

        [Fact]
        public void ShouldExecuteCleanUpInConstuctor()
        {
            try
            {
                new TestContext( );
            } 
            catch( Exception ) 
            {
                Assert.True(TestContext.testContextCleanUpExecuted);
            }
        }
    }
}