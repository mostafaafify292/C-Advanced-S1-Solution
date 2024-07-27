using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_S1
{
    public class Range<T> where T : IComparable
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public Range(int _Min,int _Max)
        {
            MinValue = _Min;
            MaxValue = _Max;
        }
        public void IsInRange(T Value)
        {
            if (Value.CompareTo(MaxValue) == -1 && Value.CompareTo(MinValue) == 1)
            { 
                Console.WriteLine("True \n ValueOnRange"); 
            
            }
            else
            {
                Console.WriteLine("    false \nValueOutOfRange");
            }

        }
        public void Length()
        {
            Console.WriteLine($"the Length Is [{MaxValue - MinValue}]");
        }
        
        

    }
}
