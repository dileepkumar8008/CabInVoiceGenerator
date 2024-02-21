using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice
{
    public class Program
    {
        static double cost_per_kilometer = 10.0;
        static double cost_per_minute = 1.0;
        static int min_fair = 5;
        static int total = 0;
        static void Main(string[] args)
        {
           
        }
        public static double totalFair(double distance,int time)
        {
            double result = (distance * cost_per_kilometer) +( time * cost_per_minute);
            if(result<5)
            {
                return min_fair;
            }
            return result;
        }
        public static int totalRides(int time) 
        {
            return total;
        }
       

    }
}
