using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Circle : IShape
    {
        public void Area(int Result){
        Console.WriteLine("Circle area is "+ Result);
        }
        public void Circumferance(int Result){
        Console.WriteLine("Circle circumferance is "+ Result);
        }
    }
