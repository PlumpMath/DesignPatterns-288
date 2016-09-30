namespace DesignPatterns
{
    public class Duck
    {
        internal IFlyBehavior flyBehavior;
        internal IQuackBehavior quackBehavior;
        
        public string PerformFly()
        {
            return flyBehavior.Fly();
        }

        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }
    }
}
