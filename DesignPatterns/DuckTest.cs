using NUnit.Framework;
using Shouldly;

namespace DesignPatterns
{
    [TestFixture]
    public class DuckTest
    {
        [Test]
        public void MallardDuck_Quack()
        {
            var mallard = new Mallard();
            var noise = mallard.PerformQuack();
            noise.ShouldBe("Quack!");
        }

        [Test]
        public void MallardDuck_Display()
        {
            var mallard = new Mallard();
            var look = mallard.Display();
            look.ShouldBe("A fine mallard");
        }

        [Test]
        public void Mallard_Fly()
        {
            var mallard = new Mallard();
            var fly = mallard.PerformFly();
            fly.ShouldBe("Fly away...");
        }

        [Test]
        public void RedheadDuck_Quack()
        {
            var redhead = new Redhead();
            var noise = redhead.PerformQuack();
            noise.ShouldBe("Quack!");
        }

        [Test]
        public void RedheadDuck_Display()
        {
            var redhead = new Redhead();
            var look = redhead.Display();
            look.ShouldBe("Noble redhead");
        }

        [Test]
        public void Redhead_Fly()
        {
            var redhead = new Redhead();
            var fly = redhead.PerformFly();
            fly.ShouldBe("Fly away...");
        }

        [Test]
        public void RubberDuck_Quack()
        {
            var rubber = new Rubber();
            var noise = rubber.PerformQuack();
            noise.ShouldBe("Squeak");
        }

        [Test]
        public void RubberDuck_Display()
        {
            var rubber = new Rubber();
            var look = rubber.Display();
            look.ShouldBe("Rubber duckie");
        }

        [Test]
        public void WoodenDecoyDuck_Display()
        {
            var woodenDecoy = new WoodenDecoy();
            var look = woodenDecoy.Display();
            look.ShouldBe("WoodenDecoy");
        }

        [Test]
        public void DuckCall_Quack()
        {
            var duckCall = new DuckCall.DuckCall();
            var look = duckCall.Quack();
            look.ShouldBe("Quack!");
        }
    }
}
