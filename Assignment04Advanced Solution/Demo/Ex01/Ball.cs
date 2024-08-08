using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ex01
{
    internal class Ball
    {
        public int ID { get; set; }
        private Location X;
        public Location LocationOfBall
        {
            get
            {
                return X;
            }

            set
            {
                if (!value.Equals(X))
                {
                    X = value;
                    BallChangedEvent?.Invoke(this);
                }
            }
        }

        public event Action<Ball>? BallChangedEvent;

        public override string ToString()
        {
            return $"ID : {ID} , Location {LocationOfBall}";
        }
    }
}
