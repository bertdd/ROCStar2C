namespace ROCStarBackend;

public class Teacher
{
    public int ID { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public DateOnly BirthDate { get; set; }
}
