using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_array
{
    public class Sortarray : Array
    {
        public Sortarray(int[] arr) : base(arr) { }
        public override Array Add(Array other)
        {
            Sortarray o = other as Sortarray;
            HashSet<int> set = new HashSet<int>();

            foreach (var item in data)
            {
                set.Add(item);
            }

            foreach (var item in o.data)
            {
                set.Add(item);
            }

            return new Sortarray(set.ToArray());
        }

        public override void Process()
        {
            foreach (var item in data)
            {

            }
            System.Array.Sort(data);
        }

        public override string Display()
        {
            return string.Join(" ", data);
        }
    }
}
