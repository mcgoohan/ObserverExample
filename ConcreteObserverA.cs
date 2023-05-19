namespace ObserverExample;

public class ConcreteObserverA : IObserver
{
    public void Update()
    {
        Console.WriteLine("Hello from ConcreteObserverA");
    }
}