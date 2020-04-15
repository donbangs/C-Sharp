using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MyGenericList<T> where T : IComparable
    {
        private T[] genericArray;

        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        
        public MyGenericList()
        {
            genericArray = new T[50];
        }

        public void Add(T value)
        {
                if (count == genericArray.Length)
                {
                    T[] copy = new T[genericArray.Length + 50];
                    genericArray.CopyTo(copy, 0);
                    genericArray = copy;
                }

                int comparer, i = -1;
                do
                {
                    i++;
                    comparer = value.CompareTo(genericArray[i]);
                } while (comparer >= 0 && i != count);
                T buf2;
                T buf = genericArray[i];
                genericArray[i] = value;
                for (; i < count; i++)
                {
                    buf2 = genericArray[i + 1];
                    genericArray[i + 1] = buf;
                    buf = buf2;
                }
                count++;          
        }
        public bool IsOK(object obj)
        {
            //Type t = genericArray.GetType();
           // Type t2 = obj.GetType();
            if (genericArray[0].GetType() == obj.GetType()) return true;
            return false;
        }
        public void Delete(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    genericArray[i] = genericArray[i + 1];
                }
                count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count) return genericArray[index];
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
