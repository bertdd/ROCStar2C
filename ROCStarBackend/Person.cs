namespace ROCStarBackend;

public abstract class Person
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public required string Email { get; set; }
  public DateOnly BirthDate { get; set; }
}
