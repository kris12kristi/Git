using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Client
    {
        private AbstractLecture abstractLecture;
        private AbstractSeminar abstractSeminar;
        private AbstractPractic abstractPractic;

        public Client(AbstractFactory_Kafedras factory_Kafedras)
        {
            abstractLecture = factory_Kafedras.CreateLecture();
            abstractSeminar = factory_Kafedras.CreateSeminar();
            abstractPractic = factory_Kafedras.CreatePractic();
        }

        public void Run()
        {
            abstractLecture.Interact(abstractLecture);
            abstractSeminar.Interact(abstractSeminar);
            abstractPractic.Interact(abstractPractic);
        }


    }
}
