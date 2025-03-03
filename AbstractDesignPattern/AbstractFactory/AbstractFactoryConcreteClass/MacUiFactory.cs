using ADP.AbstractFactory.AbstractFactoryInterface;
using ADP.AbstractProductInterface.AbstractInterface;
using ADP.AbstractProductInterface.ConcreteClass;

namespace ADP.AbstractFactory.AbstractFactoryConcreteClass;

public class MacUiFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckBox();
    }
}