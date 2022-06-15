using SimUDuck_Strategy.Abstract;

namespace SimUDuck_Strategy.Concrete.Behaviors.QuackBehaviors;

internal class MuteQuackBehavior : IQuackBehavior
{
    public void Quack() => Console.WriteLine("<< Silence >>");
}