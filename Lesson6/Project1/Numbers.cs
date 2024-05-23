using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Numbers
    {
        string[] arr;
        public Numbers(string s)
        {
            arr = s.Split(' ');
        }

        public string this[int index]
        {
            get
            {
                if (arr.Length != 0)
                {
                    if (index >= arr.Length)
                    {
                        return null;
                    }
                    else
                    {
                        return arr[index];
                    }
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (arr.Length != 0)
                {
                    if (index < arr.Length)
                    {
                        arr[index] = value;
                    }
                }
            }
        }

        public bool Contains(string num)
        {
            return arr.Contains(num);
        }

        public string Min()
        {
            string min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
