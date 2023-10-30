﻿namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo
    {
        public DateTime StartupTime { get; init; }

        public Demo()
        {
            this.StartupTime = DateTime.Now;
        }
    }
}
