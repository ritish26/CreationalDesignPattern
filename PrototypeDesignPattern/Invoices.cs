namespace PDP;

public class Invoices : DocumentPrototype
{
    public string? InvoiceNumber { get; set; }
    
    public override DocumentPrototype Clone()
    {
        Title = this.Title;
        Content = this.Content;
        InvoiceNumber = this.InvoiceNumber;
        return this;
    }

    public override string ToString()
    {
        return $"Invoices: {InvoiceNumber} - {Title} - {Content}";
    }
}