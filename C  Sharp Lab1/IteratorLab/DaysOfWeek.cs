using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorLab
{

    class DaysOfWeek: IEnumerable
    {
        string[] days =
        {
            "Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat"
        };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i]; //yield prevents returning of control until loop ends
            }
        }
    }
}
