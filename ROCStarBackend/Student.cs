namespace ROCStarBackend;

/// <summary>
/// Represents the data for a student
/// </summary>
public class Student : Person
{
  public DateTime Registered {  get; set; }

  public string? PreviousSchool { get; set; }
}
