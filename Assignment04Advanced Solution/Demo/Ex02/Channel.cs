using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ex02
{
    internal class Channel1
    {
        public string ChannelName { get; set; }
        public List<Video> Videos { get; set; }

        public Channel1()
        {
            Videos = new List<Video>();
        }

        public event Action<Channel1, Video>? ChannelAddedVideoEvent;
        public void AddNewVideo(string S1, string S2)
        {
            Video V = new Video(S1, S2);
            Videos.Add(V);

            ChannelAddedVideoEvent?.Invoke(this, V);
        }
    }
}
