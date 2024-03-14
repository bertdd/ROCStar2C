namespace ROCStarBackend;

public class Docent(int id, string name) : Person(id, name)
{
  public decimal Salary { get; set; }
}

