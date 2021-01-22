using System;

namespace Estrutura
{
    public class Pilha
    {
        Posicao primeiro;

        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }


        class Posicao
        {
            public Posicao proximo;

            public object item;

            public Posicao(Posicao proximo, object item) // Construtor
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}