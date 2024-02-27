namespace ROCStarBackend;

public class Group(string id)
{
  public string Id { get; set; } = id;
  public List<Student> Students { get; } = [];
  public Teacher? Mentor { get; set; }

}
