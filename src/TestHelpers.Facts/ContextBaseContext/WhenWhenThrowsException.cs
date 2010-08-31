using System;
using Xunit;

namespace TestHelpers.ContextBaseContext
{
    public class WhenWhenThrowsException : ContextBaseContext
    {
        public class TestContext : ContextBase
        {
            public InvalidOperationException thrownException;

            public override void When()
            {
                throw new InvalidOperationException();
            }
        }

        [Fact]
        public void ConstructorShouldNotThrowException()
        {
            Assert.DoesNotThrow( () => new TestContext( ) );
        }

        [Fact]
        public void ExceptionMethodShouldRethrowException()
        {
            var testContext = new TestContext( );
            Assert.Throws<InvalidOperationException>(() => testContext.Exception());
        }
    }
}