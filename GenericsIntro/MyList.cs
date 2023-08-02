using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        
        //constructor(Yapıcı Metod)
        public MyList()
        {
            items = new T[0]; 
        }

        public void Add(T item)
        { 

        };
    }
}
