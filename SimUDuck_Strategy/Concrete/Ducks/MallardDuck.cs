using SimUDuck_Strategy.Abstract;
using SimUDuck_Strategy.Concrete.Behaviors.FlyBehaviors;
using SimUDuck_Strategy.Concrete.Behaviors.QuackBehaviors;

namespace SimUDuck_Strategy.Concrete.Ducks;

internal class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new QuackBehavior();
        FlyBehavior = new FlyWithWingsBehavior();
    }

    public override void Display() => Console.WriteLine(nameof(MallardDuck));
}