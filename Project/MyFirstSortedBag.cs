using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MyFirstSortedBag : ISortedBag
    {
       private static List<int> list = new List<int>();
        public int Add(int id)
        {
            list.Add(id);
            return id;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public int Get
        {
            get
            {
                list.Remove(Peek);
                return 0;
            }
        }
        public int Peek
        {
            get { return list.Min(); }
        }
    }
}
