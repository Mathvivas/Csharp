using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic 
{
    class UsandoDynamics : IAulaItem {
        
        public void Executar() {

            // Tipo é definido na compilação
            string s = "Certificação C#";
            // Tipo é definido na compilação (por inferência)
            var v = "Certificação C#";
            // Tipo é definido na compilação
            object o = "Certificação C#";

            System.Console.WriteLine(s);
            System.Console.WriteLine(v);
            System.Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            System.Console.WriteLine(s);
            System.Console.WriteLine(v);
            System.Console.WriteLine(o);

            //s = 123;    // Erro
            //v = 123;    // Erro
            o = 123;

            o = (int)o + 4;

            System.Console.WriteLine(o);

            // Tipo é definido em execução
            dynamic d = "Certificação C#";
            System.Console.WriteLine(d);

            d = d.ToUpper();
            System.Console.WriteLine(d);
            
            d = 123;
            System.Console.WriteLine(d);

            d = d + 4;
            System.Console.WriteLine(d);
        }
    }
}