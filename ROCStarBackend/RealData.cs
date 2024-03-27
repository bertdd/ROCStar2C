using MySql.Data.MySqlClient;

namespace ROCStarBackend;

public class RealData
{
  public static Group GetGroup()
  {
    var group = new Group("OITSDO2A");

    var connectionString = new MySqlConnectionStringBuilder
    {
      UserID = "root",
      Password = "",
      Port = 3306,
      Server = "localhost",
      Database = "test"
    }.ToString();

    using var connection = new MySqlConnection(connectionString);
    connection.Open();

    using var command = connection.CreateCommand();
    command.CommandText = "select * from student";
    using var reader = command.ExecuteReader();
    while (reader.Read())
    {
      group.Students.Add(new Student((int)reader["id"], (string)reader["name"]));
    }

    connection.Close();
    return group;
  }
}
