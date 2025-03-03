namespace PDP;

public class Reports : DocumentPrototype
{
    private string? ReportType { get; set; }
    
    public override DocumentPrototype Clone()
    {
        Title = this.Title;
        Content = this.Content;
        ReportType = this.ReportType;
        return this;
    }

    public override string ToString()
    {
        return $"Report Type: {ReportType}-{Content}-{ReportType}";
    }
}