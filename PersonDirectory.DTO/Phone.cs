namespace PersonDirectory.DTO;

public class Phone
{
    public int Id { get; set; }
    public PhoneType PhoneType { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public Person? People { get; set; }
}
public enum PhoneType : byte
{
    Personal = 0,
    Office = 1,
    Home = 2
}