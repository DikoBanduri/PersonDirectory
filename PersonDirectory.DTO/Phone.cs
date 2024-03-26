namespace PersonDirectory.DTO;

public class Phone
{
    public int Id { get; set; }
    public string Personal { get; set; } = null!;
    public string? Home { get; set; }
    public string? Office { get; set; }
    public string? Additional { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public Person? People { get; set; }
}