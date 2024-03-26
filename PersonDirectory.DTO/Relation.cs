namespace PersonDirectory.DTO;

public class Relation
{
    public int Id { get; set; }
    public int FromId { get; set; }
    public int ToId { get; set; }
    public Type Type { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public Person FromPerson { get; set; } = null!;
    public Person ToPerson{ get; set; } = null!;
}

public enum Type : byte
{
    Friend = 0,
    Relative = 1,
    Colleague = 2
}