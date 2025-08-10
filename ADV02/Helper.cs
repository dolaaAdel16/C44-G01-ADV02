using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
    internal class Helper
    {
        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i]; // Sum = Sum +list[i]
                }


            }
            return Sum;

        }
        


    }
}

