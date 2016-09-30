namespace DesignPatterns
{
    internal class Mallard : Duck
    {
        public Mallard()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new StandardQuack();
        }

        public string Display()
        {
            return "A fine mallard";
        }
    }
}