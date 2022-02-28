using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    class Karnataka : IState, IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void StateAnimal()
        {
            
            Console.WriteLine("Indian Elephant");
        }

        public void StateFlag()
        {
            Console.WriteLine("State Flag - Yello & Red");
        }
    }

    class AndraPradesh : IState
    {
        public void StateAnimal()
        {
            throw new NotImplementedException();
        }

        public void StateFlag()
        {
            throw new NotImplementedException();
        }
    }

}
