using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_array
{
    public abstract class Array
    {
        protected int[] data;

        public Array(int[] arr)
        {
            data = arr;
        }

        public abstract Array Add(Array other);
        public abstract void Process();
        public abstract string Display();
    }
}
