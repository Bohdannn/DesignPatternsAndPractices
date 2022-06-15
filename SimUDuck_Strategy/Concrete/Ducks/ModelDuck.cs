using SimUDuck_Strategy.Abstract;
using SimUDuck_Strategy.Concrete.Behaviors.FlyBehaviors;
using SimUDuck_Strategy.Concrete.Behaviors.QuackBehaviors;

namespace SimUDuck_Strategy.Concrete.Ducks;

internal class ModelDuck : Duck
{
    public ModelDuck()
    {
        QuackBehavior = new QuackBehavior();
        FlyBehavior = new FlyNoWayBehavior();
    }

    public override void Display() => Console.WriteLine(nameof(ModelDuck));
}