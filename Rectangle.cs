using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    public class Rectangle: IShape
    {
      
        public void Area(int Result){
             Console.WriteLine("Rectangle area is " + Result);
        }
        public void Circumferance(int Result){
            
            Console.WriteLine("Rectangle Circumferance is"+ Result);
        }
    }
