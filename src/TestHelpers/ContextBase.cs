using System;

namespace TestHelpers
{
    public class ContextBase : IDisposable
    {
        public ContextBase()
        {
            try
            {
                Given();
            }
            catch
            {
                CleanUp();
                throw;
            }

            try
            {
                When();
            }
            catch(Exception ex)
            {
                savedException = ex;
            }
        }

        private readonly Exception savedException;

        public void Dispose()
        {
            CleanUp();
        }

        public virtual void Given() { }
        public virtual void When() { }

        public void Exception()
        {
            if (savedException != null) throw savedException;
        }

        public virtual void CleanUp() { }
    }
}
