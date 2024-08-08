using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ex02
{
    internal class Subscriber
    {
        public string Name { get; set; }

        public Subscriber()
        {
            
        }

        public Subscriber(string name)
        {
            this.Name = name;
        }

        public void Notify(Channel1 Ch, Video V)
        {
            Console.WriteLine($"{Name} : {Ch.ChannelName} Added New Video {V}");
        }
    }
}
