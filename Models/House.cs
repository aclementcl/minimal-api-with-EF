namespace entityFramework.Models;

public class House
{
    public Guid HouseId { get; set; }
    public string Title { get; set; }
    public string Motto { get; set; }
    public string? Description { get; set; }
    public string? ShieldUrl { get; set; }
    public Influence HouseInfluence { get; set; }
    public DateTime StartDate { get; set; }
    public virtual ICollection<Person> People {get; set;}
}

public enum Influence
{
    Low,
    Middle,
    Hight
}