namespace ROCStarBackend;

public abstract class Person(string name)
{
  public string Name { get; set; } = name;
  public int Id { get; set; }
  public DateOnly Birthday { get; set; }
}
