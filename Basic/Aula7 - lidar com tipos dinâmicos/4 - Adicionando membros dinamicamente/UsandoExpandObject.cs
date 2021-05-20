using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic 
{
    class UsandoExpandObject : IAulaItem {
        
        public void Executar() {
            string json = "{\"De\": \"Paulo Silveira\"," + 
            "\"Para\": \"Guilherme Silveira\"}";

            var mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            mensagem.Texto = Olá, + mensagem.Para;

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(() = >
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
                mensagem.Texto = "Olá, " + mensagem.Para;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg) {
            System.Console.WriteLine($"De: {msg.De}");
            System.Console.WriteLine($"Para: {msg.Para}");
            System.Console.WriteLine($"Texto: {msg.Texto}");
            System.Console.WriteLine();
        }
    }

    class Mensagem {

        public string De { get; set; }
        public string Para { get; set; }
        public string Texto { get; set; }
    }
}