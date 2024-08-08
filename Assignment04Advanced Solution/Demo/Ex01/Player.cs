using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ex01
{
    internal class Player
    {
        public string PlayerName { get; set; }

        public Player()
        {

        }

        public Player(string name)
        {
            PlayerName = name;
        }
        // Call-Back Function
        public void PlayerRun(Ball B)
        {
            Console.WriteLine($"{PlayerName} Is Running To {B}");
        }
    }
}
