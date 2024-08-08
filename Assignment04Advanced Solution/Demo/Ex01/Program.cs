using Demo.Ex02;
using System.Collections;
using System.Threading.Channels;

namespace Demo.Ex01
{
    internal class Program
    {
        public static void Main()
        {
            #region Event Ex01

            //// I Need To Write This Paradigm When I Need To Execute 
            //// Something At Event

            //// Create Object From Class 'Ball'
            //Ball B = new Ball();
            //B.LocationOfBall = new Location(0, 0, 0);

            //// Create Object From Class 'Player'
            //Player P1 = new Player("Shikabala");
            //Player P2 = new Player("ZiZo");

            //// Add This Player In The InvokationList Because When The BallChanged These Players Running
            //B.BallChangedEvent += P1.PlayerRun;
            //B.BallChangedEvent += P2.PlayerRun;

            //B.LocationOfBall = new Location(1, 1, 1);

            //// Zizo Out So We Must Remove Him From Invokation List
            //B.BallChangedEvent -= P2.PlayerRun;

            //Player P3 = new Player("Mido");
            //// Mido In So We Must Add Him To Invokation List
            //B.BallChangedEvent += P3.PlayerRun;

            //// So When The BallLocation Changed The Call-Back Functions Will Run
            //B.LocationOfBall = new Location(2, 2, 2);

            #endregion

            #region Event Ex02

            //Channel1 Ch = new Channel1();

            //Ch.AddNewVideo("Back-End", "Informations");

            //Subscriber S1 = new Subscriber("Diaa");
            //Subscriber S2 = new Subscriber("Ahmed");
            //Subscriber S3 = new Subscriber("Ali");
            //Subscriber S4 = new Subscriber("Mazen");

            //Ch.ChannelAddedVideoEvent += S1.Notify;
            //Ch.ChannelAddedVideoEvent += S2.Notify;
            //Ch.ChannelAddedVideoEvent += S3.Notify;
            //Ch.ChannelAddedVideoEvent += S4.Notify;

            //Ch.AddNewVideo("Back-End", "Informations");


            #endregion

            #region Hashtable Collection

            //// Hashtable
            //// Non-Generic Collection
            //// Store The Data As Pair(Key, Value)
            //// Key Is A Object
            //// Value Is A Object

            //Hashtable Note01 = new Hashtable();

            //Note01.Add(1, "Diaa");
            //Note01.Add(2, "Ahmed");
            //Note01.Add(3, "Ali");

            //Console.WriteLine(Note01.Count);

            //foreach(DictionaryEntry i in Note01)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList L1 = new ArrayList(Note01.Keys);
            //ArrayList L2 = new ArrayList(Note01.Values);

            //Note01.Remove(1);

            //bool Flag01 = Note01.ContainsKey(1);
            //bool Flag02 = Note01.ContainsValue("Diaa");

            #endregion

            #region Dictionary Collection

            //// Dictionary
            //// Generic Version Of Hashtable

            //Dictionary<int, string> Note02 = new Dictionary<int, string>();

            //Note02.Add(1, "Diaa");
            //Note02.Add(2, "Ahmed");
            //Note02.Add(3, "Rawan");

            //Console.WriteLine(Note02.Count);

            //// Cannot Add Not Int Key Or Not String Value
            //// Store Entries With Order Not Changed When I Rerun The Program

            //// The Same Methods In The Hashtable Collection

            //Note02.Remove(1, out string? s1);
            //bool Flag1 = Note02.TryAdd(1, "Ahmed");
            //bool Flag2 = Note02.TryGetValue(1, out string? s2);

            #endregion
        }
    }
}