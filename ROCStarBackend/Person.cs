namespace ROCStarBackend;

public abstract class Person(int id, string name)
{
  public string Name { get; set; } = name;
  public int Id { get; set; } = id;
  public DateOnly Birthday { get; set; }
}
