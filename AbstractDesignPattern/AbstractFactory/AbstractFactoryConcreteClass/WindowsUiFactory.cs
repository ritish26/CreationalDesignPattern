using ADP.AbstractFactory.AbstractFactoryInterface;
using ADP.AbstractProductInterface.AbstractInterface;
using ADP.AbstractProductInterface.ConcreteClass;

namespace ADP.AbstractFactory.AbstractFactoryConcreteClass;

public class WindowsUiFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckBox();
    }
}