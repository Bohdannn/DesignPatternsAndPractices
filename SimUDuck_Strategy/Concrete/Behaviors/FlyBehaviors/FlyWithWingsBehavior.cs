using SimUDuck_Strategy.Abstract;

namespace SimUDuck_Strategy.Concrete.Behaviors.FlyBehaviors;

internal class FlyWithWingsBehavior : IFlyBehavior
{
    public void Fly() => Console.WriteLine("I'm flying using wings!");
}