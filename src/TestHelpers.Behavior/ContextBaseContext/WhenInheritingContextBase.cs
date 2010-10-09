using System;
using Xunit;

namespace TestHelpers.ContextBaseContext
{
    public class WhenInheritingContextBase : ContextBaseContext
    {
        [Fact]
        public void ShouldExecuteGivenInConstructor()
        {
            Assert.True(givenExecuted);
        }

        [Fact]
        public void ShouldExecuteWhenInConstructor()
        {
            Assert.True(whenExecuted);
        }

        [Fact]
        public void ShouldImplementIDisposable()
        {
            Assert.IsAssignableFrom<IDisposable>( this );
        }
    }
}