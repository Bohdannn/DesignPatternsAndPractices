using SimUDuck_Strategy.Abstract;

namespace SimUDuck_Strategy.Concrete.Behaviors.QuackBehaviors;

internal class SqueakBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("Squeak");
}