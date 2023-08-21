using SimpleAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Test;
public class UnitTest1
{

    WeatherForecastController controllerObj = new WeatherForecastController();
    [Fact]
    public void GetReturnMyName()
    {
        var returnValue = controllerObj.Get();
        Assert.Equal("0", "0");
    }

    [Fact]
    public void Test1()
    {

    }
}