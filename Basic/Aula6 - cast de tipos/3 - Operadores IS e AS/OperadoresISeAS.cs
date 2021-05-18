using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj) {

            if ( obj is Animal animal ) {
                animal.Beber();
                animal.Comer();
                return;
            }

            System.Console.WriteLine("obj não é um animal");

            // Quando não for possível realizar a conversão, animal será null
            // Animal animal = obj as Animal

            // if (animal == null) {
            //     System.Console.WriteLine("obj não é um animal");
            // }
            
            // animal.Beber();
            // animal.Comer();
        }
    }
}
