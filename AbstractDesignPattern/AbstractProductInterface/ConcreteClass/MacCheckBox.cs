using ADP.AbstractProductInterface.AbstractInterface;

namespace ADP.AbstractProductInterface.ConcreteClass;

public class MacCheckBox : ICheckbox
{
    public void Check()
    {
        Console.WriteLine("Mac CheckBox Created");
    }
}