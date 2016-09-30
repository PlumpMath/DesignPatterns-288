namespace DesignPatterns
{
    public class Rubber : Duck
    {
        public Rubber()
        {
            quackBehavior = new Squeak();
        }

        public string Display()
        {
            return "Rubber duckie";
        }
    }
}