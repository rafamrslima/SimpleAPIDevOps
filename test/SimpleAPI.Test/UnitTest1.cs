using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{  
    ValuesController controller = new ValuesController();

    [Fact]
    public void TestValues()
    {
        var expected = "Hello Devops World";
        var result = controller.Get();
        Assert.Equal(expected, result);
    }
}