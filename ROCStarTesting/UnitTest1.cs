using ROCStarBackend;

namespace ROCStarTesting;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void StudentTest()
  {
    var student = new Student()
    {
      Id = 1,
    };

    Assert.AreEqual(1, student.Id);
  }

  [TestMethod]
  public void StudentNameTest()
  {
    var student = new Student()
    {
      Id = 1,
      Name = "Martino"
    };

    Assert.AreNotEqual(0, student.Id);
    Assert.AreEqual("Martino", student.Name);
  }

  [TestMethod]
  public void TestPerson()
  {
    Person person = new Student()
    {
      BirthDate = new DateOnly(2015, 5, 1)
    };

    Assert.AreEqual(person.BirthDate.Year, 2015);
  }
}