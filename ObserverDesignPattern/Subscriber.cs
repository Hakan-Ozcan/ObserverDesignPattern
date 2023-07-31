using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Subscriber : IObserver
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string news)
        {
            Console.WriteLine($"{name} received news: {news}");
        }
    }
}
