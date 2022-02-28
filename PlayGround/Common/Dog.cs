using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Dog : Animal, IDisposable, IEnumerable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {   
            //Code
            Console.WriteLine("Dog runs on 4 legs");
        }
    }
}
