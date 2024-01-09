using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    internal class Refers
    {

        public void Method()
        {
            int number = 10;
            ref int nimber_ref = ref number;
        }

        public static ref int Find(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == key)
                    return ref array[i];
            throw new Exception();
        }
    }
}
