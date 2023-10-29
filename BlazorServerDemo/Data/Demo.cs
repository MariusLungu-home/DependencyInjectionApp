namespace BlazorServerDemo.Data
{
    public class Demo
    {
        public DateTime StartupTime { get; init; }

        public Demo()
        {
            this.StartupTime = DateTime.Now;
        }
    }
}
