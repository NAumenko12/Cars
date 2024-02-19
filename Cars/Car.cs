using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carss
{
     public class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Distance { get; set; }
        public int CurrentSpeed { get; set; }

        public Car(string name, int maxSpeed, int distance)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Distance = distance;
            CurrentSpeed = 0;
        }

        public void Accelerate()
        {
            if (CurrentSpeed < MaxSpeed)
            {
                CurrentSpeed += 10;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = MaxSpeed;
                }
            }
        }

        public void Decelerate()
        {
            if (CurrentSpeed > 0)
            {
                CurrentSpeed -= 5;
                if (CurrentSpeed < 0)
                {
                    CurrentSpeed = 0;
                }
            }
        }

        public void Move()
        {
            Accelerate();
            Distance += CurrentSpeed;
        }
    }
}
