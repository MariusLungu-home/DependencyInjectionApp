using BlazorServerDemo.Data;
using System.Drawing;

namespace BlazorServerDemo.Test
{
    public class ProcessDemoTests
    {
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("1/2/2000"));
            ProcessDemo p = new(t);

            int expected = 29;
            int actual = p.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }
    }

    public class TestingDemo : IDemo
    {
        public DateTime StartupTime { get; init; }

        public TestingDemo(DateTime startTime)
        {
            StartupTime = startTime;
        }
    }
}