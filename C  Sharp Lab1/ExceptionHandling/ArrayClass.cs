using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ArrayClass
    {
        public int [] arr;
        public ArrayClass(int n)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
        }

        public int GetItem(int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException ex)
            {

                //Console.WriteLine("Index is out of range");
                //Console.WriteLine(ex.Message);
                //return 0;
                throw new InvalidIndexException("Index Out of Range");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
    }
}
