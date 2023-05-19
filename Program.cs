using ObserverExample;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", 
    () =>
    {
        Subject subject = new Subject();
        subject.Attach(new ConcreteObserverA());
        subject.Attach(new ConcreteObserverB());
        subject.Notify();
        return "Hello World!";
    });

app.Run();

