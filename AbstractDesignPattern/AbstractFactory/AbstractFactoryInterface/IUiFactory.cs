using ADP.AbstractProductInterface.AbstractInterface;

namespace ADP.AbstractFactory.AbstractFactoryInterface;

public interface IUiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}