namespace PDP;

public abstract class DocumentPrototype
{
    public string Title { get; set; }
    public string Content { get; set; }

    public abstract DocumentPrototype Clone();
    
}