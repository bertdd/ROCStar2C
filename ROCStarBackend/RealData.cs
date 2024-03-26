using MySql.Data.MySqlClient;

namespace ROCStarBackend;

public class RealData
{
  public static Group GetGroup()
  {
    var group = new Group("OITSDO2E");

    var connectionString = new MySqlConnectionStringBuilder
    {
      Server = "localhost",
      Port = 3306,
      UserID = "root",
      Password = "",
      Database = "test"
    }.ToString();

    using var connection = new MySqlConnection(connectionString);
    connection.Open();

    using var command = connection.CreateCommand();
    command.CommandText = $"select * from {tableName}";
    using var reader = command.ExecuteReader();
    while (reader.Read())
    {
      group.Add(new Student(reader.GetInt32("id"), reader.GetString("name")));
    }

    return group;
  }

  private static readonly string tableName = "student";
}
