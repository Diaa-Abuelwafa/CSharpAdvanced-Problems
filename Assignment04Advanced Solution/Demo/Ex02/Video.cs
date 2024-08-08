using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ex02
{
    internal class Video
    {
        public string VideoName { get; set; }
        public string Discription { get; set; }

        public Video()
        {
            
        }

        public Video(string S1, string S2)
        {
            this.VideoName = S1;
            this.Discription = S2;
        }

        public override string ToString()
        {
            return $"VideoName : {VideoName} , VideoDiscription : {Discription}";
        }
    }
}
