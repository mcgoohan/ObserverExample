namespace ObserverExample;

public class ConcreteObserverB : IObserver
{
    public void Update()
    {
        Console.WriteLine("Hello from ConcreteObserverB");
    }
}