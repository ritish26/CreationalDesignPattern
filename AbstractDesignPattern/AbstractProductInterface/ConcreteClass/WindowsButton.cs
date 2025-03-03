using ADP.AbstractProductInterface.AbstractInterface;

namespace ADP.AbstractProductInterface.ConcreteClass;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Button");
    }
}