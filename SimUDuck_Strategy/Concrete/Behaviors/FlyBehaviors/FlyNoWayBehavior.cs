using SimUDuck_Strategy.Abstract;

namespace SimUDuck_Strategy.Concrete.Behaviors.FlyBehaviors;

internal class FlyNoWayBehavior : IFlyBehavior
{
    public void Fly() => Console.WriteLine("I can't fly!");
}