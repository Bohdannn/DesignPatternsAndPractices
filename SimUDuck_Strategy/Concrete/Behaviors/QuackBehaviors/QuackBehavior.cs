using SimUDuck_Strategy.Abstract;

namespace SimUDuck_Strategy.Concrete.Behaviors.QuackBehaviors;

internal class QuackBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("Quack");
}