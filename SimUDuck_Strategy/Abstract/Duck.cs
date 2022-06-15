namespace SimUDuck_Strategy.Abstract;

internal abstract class Duck
{
    public IFlyBehavior FlyBehavior { private get; set; }
    public IQuackBehavior QuackBehavior { private get; set; }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }

    public abstract void Display();
}