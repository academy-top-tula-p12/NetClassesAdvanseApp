using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassesAdvanseApp
{
    class Matrix
    {
        int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        public int this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }
    }

    class Calendar
    {
        Dictionary<string, int[]> calendar = new()
        {
            { "Jan", new int[]{ 1, 2, 3, 4 } },
            { "Feb", new int[]{ 5, 6, 7, 8 } },
            { "Mar", new int[]{ 9, 10, 11, 12 } },
        };

        public int this[string month, int day]
        {
            get => calendar[month][day];
            set => calendar[month][day] = value;
        }


    }
}
