using SimUDuck_Strategy.Abstract;

namespace SimUDuck_Strategy.Concrete.Behaviors.FlyBehaviors;

internal class FlyRocketPoweredBehavior : IFlyBehavior
{
    public void Fly() => Console.WriteLine("I'm flying with a rocket!");
}