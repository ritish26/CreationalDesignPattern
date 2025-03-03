using ADP.AbstractProductInterface.AbstractInterface;

namespace ADP.AbstractProductInterface.ConcreteClass;

public class WindowsCheckBox : ICheckbox
{
    public void Check()
    {
        Console.WriteLine("Windows CheckBox Created");
    }
}