using ROCStarBackend;

namespace ROCStarTester;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void TestCreateStudent()
  {
    var student = new Student("Mous");
    Assert.IsNotNull(student);
  }

  [TestMethod]
  public void TestCreateDocent()
  {
    var docent = new Docent("Bert");
    Assert.IsNotNull(docent);
    Assert.AreSame(docent.Name, "Bert");
  }
}
