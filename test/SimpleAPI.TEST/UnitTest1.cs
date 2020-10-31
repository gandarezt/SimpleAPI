using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {


        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyÑame()
        {
            var returnValue = controller.GetName();
            Assert.Equal("Tiago Gandarez", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
