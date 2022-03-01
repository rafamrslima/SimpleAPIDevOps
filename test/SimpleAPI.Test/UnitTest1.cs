using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{  
    ValuesController controller = new ValuesController();

    [Fact]
    public void TestValues()
    {
        var expected = "1234";
        var result = controller.Get();
        Assert.Equal(expected, result);
    }
}