using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArraySolutionProgram
{
    public class DynamicArray
    {

        int[] buffer;


        public DynamicArray()
        {
            buffer = new int[5];
        }
        public DynamicArray(int initialSize)
        {
            buffer = new int[initialSize];
        }

        public int Capacity
        {
            get
            {
                return buffer.Length;
            }
        }
        public int this[int index]
        {
            set
            {
                Array.Resize(ref buffer, index + 5);
                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }
        }
    }
       
}
