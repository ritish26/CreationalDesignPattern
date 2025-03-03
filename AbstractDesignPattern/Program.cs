// See https://aka.ms/new-console-template for more information

using ADP.AbstractFactory.AbstractFactoryConcreteClass;
using ADP.AbstractFactory.AbstractFactoryInterface;
using ADP.AbstractProductInterface.AbstractInterface;

///Problem Statement : 
/// You are designing a cross-platform UI framework that supports multiple operating systems,
/// such as Windows and macOS. Each OS requires different UI components like buttons and checkboxes,
/// but they should follow a common interface.

#region Program
public class Program
{
    public static void Main(string[] args)
    {
        IUiFactory windows = new WindowsUiFactory();
        IButton windowsButtonHelper = windows.CreateButton();
        windowsButtonHelper.Render();
       
        IUiFactory mac = new MacUiFactory();
        ICheckbox macCheckboxHelper = mac.CreateCheckbox();
        macCheckboxHelper.Check();
       
        
    }
}
#endregion
