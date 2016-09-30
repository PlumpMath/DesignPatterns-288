namespace DesignPatterns
{
    internal class Redhead : Duck
    {
        public Redhead()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new StandardQuack();
        }

        public string Display()
        {
            return "Noble redhead";
        }
    }
}