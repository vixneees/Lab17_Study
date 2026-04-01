using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_array
{
    public class Xorarray : Array
    {
        public Xorarray(int[] arr) : base(arr) { }
        public override Array Add(Array other)
        {
            Xorarray o = other as Xorarray;

            if (data.Length != o.data.Length)
            {
                throw new Exception("Масиви тільки однакової довжини");
            }

            int[] result = new int[data.Length];
            int i = 0;

            foreach (var item in data)
            {
                result[i] = item ^ o.data[i];
                i++;
            }
            return new Xorarray(result);
        }

        public override void Process()
        {
            int i = 0;

            foreach (var item in data)
            {
                if (item < 0)
                {
                    throw new Exception("Корінь не можу бути з від'ємного числа");
                }
                data[i] = (int)Math.Sqrt(item);
                i++;
            }
        }

        public override string Display()
        {
            return string.Join(" ", data);
        }
    }
}
