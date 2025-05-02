// See https://aka.ms/new-console-template for more information

using PDP;

/// Problem Statement :
/// Imagine you’re designing a document editor where users can create templates for different types of
/// documents (e.g., invoices, reports). These templates need to be duplicated multiple times with slight
/// modifications (We can change one property). How would you efficiently implement this feature?

/// The Prototype design pattern is a creation-al pattern that allows creating new objects by copying existing ones,
/// rather than constructing them from scratch. 

#region MainProgram
public class Program
{
    public static void Main(string[] args)
    {
        Invoices invoices = new Invoices
        {
            Title = "SX-01",
            Content = "System Design Pattern Demo",
            InvoiceNumber = "SBC9889"
        };
        
        Console.WriteLine(invoices.ToString());
        
        Invoices clonedInvoices = (Invoices)invoices.Clone();
        clonedInvoices.InvoiceNumber = "RDX2601";
        
        Console.WriteLine(invoices.ToString());

    }
}
#endregion