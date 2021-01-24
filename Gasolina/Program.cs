using System;

namespace Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "10 85";	// 1°) Tempo (horas)    2°) Velocidade (km/h)
    
            string[] entradaLista = new string[2];
            entradaLista = entrada.Split(" ");

            float tempo = float.Parse(entradaLista[0]);
            float vel = float.Parse(entradaLista[1]);
            
            float km = vel * tempo;             // Distância (km)
            
            float gas = km / 12;                // Carro faz 12 km/L
            
            Console.WriteLine(String.Format("{0:0.000}", gas));     // 3 casas decimais
        }
    }
}
