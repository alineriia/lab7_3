using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{

    class PeopleComparer : IComparer
    {
        public int Compare(Object p1, Object p2)
        {
            Person Person1 = (Person)p1;
            Person Person2 = (Person)p2;
            return Person1.Vik.CompareTo(Person2.Vik);
        }
    }
}
