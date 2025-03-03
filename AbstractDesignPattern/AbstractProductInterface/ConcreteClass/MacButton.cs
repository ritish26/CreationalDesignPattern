using ADP.AbstractProductInterface.AbstractInterface;

namespace ADP.AbstractProductInterface.ConcreteClass;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("MacButton Rendering");
    }
}