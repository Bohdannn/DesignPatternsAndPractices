using SimUDuck_Strategy.Abstract;
using SimUDuck_Strategy.Concrete.Behaviors.FlyBehaviors;
using SimUDuck_Strategy.Concrete.Ducks;

Duck mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.PerformQuack();
mallardDuck.PerformFly();
Duck modelDuck = new ModelDuck();
modelDuck.Display();
modelDuck.PerformQuack();
modelDuck.PerformFly();
modelDuck.FlyBehavior = new FlyRocketPoweredBehavior();
modelDuck.PerformFly();