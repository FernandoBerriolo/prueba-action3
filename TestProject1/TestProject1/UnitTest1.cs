using Dominio;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Usuario user = new Usuario();
        Assert.IsFalse(user.ReturnFalse());
    }
}