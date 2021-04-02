using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Status
{
    class Program1

    {
        static void Main(string[] args)
        {
            int pointx = 0; int pointy = 0;
            int circlex = 0; int circley = 0; int r = 0;

            Console.WriteLine("Enter the point-x:");
            pointx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point-y:");
            pointy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter center of circle x-coordinate:");
            circlex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter center of circle y-coordinate:");
            circley = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the circle radius:");
            r = Convert.ToInt32(Console.ReadLine());

            
                {

                
                if ((pointx - circlex) * (pointx - circlex) + (pointy - circley) * (pointy - circley) < r * r)

                    Console.WriteLine("The point is inside the circle.");

                else if ((pointx - circlex) * (pointx - circlex) + (pointy - circley) * (pointy - circley) == r * r)
                {
                    Console.WriteLine("The point is over the circle.");
                }
                else if ((pointx - circlex) * (pointx - circlex) + (pointy - circley) * (pointy - circley) > r * r)
                {
                    Console.WriteLine("The point is outside of the circle.");
                }
            }
        }
    }
}

