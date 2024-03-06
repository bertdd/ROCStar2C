using ROCStarBackend;

namespace ROCStarTesting;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void StudentTest()
  {
    var student = new Student(1, "Martino");
    Assert.AreEqual(1, student.Id);
  }

  [TestMethod]
  public void StudentNameTest()
  {
    var student = new Student(1, "Martino");
    Assert.AreNotEqual(0, student.Id);
    Assert.AreEqual("Martino", student.Name);
  }

  [TestMethod]
  public void TestPerson()
  {
    var person = new Student(500, "Lenny")
    {
      BirthDate = new DateOnly(2015, 5, 1)
    };

    Assert.AreEqual(person.BirthDate.Year, 2015);
  }
}