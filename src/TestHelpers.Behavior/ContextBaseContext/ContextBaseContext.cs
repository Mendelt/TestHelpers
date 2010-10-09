namespace TestHelpers.ContextBaseContext
{
    public class ContextBaseContext : ContextBase
    {
        public bool cleanUpExecuted;
        public bool givenExecuted;
        public bool whenExecuted;

        public override void Given()
        {
            givenExecuted = true;
        }

        public override void When()
        {
            whenExecuted = true;
        }

        public override void CleanUp()
        {
            cleanUpExecuted = true;
        }
    }
}