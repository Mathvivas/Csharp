using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEG = 0;
            const int TER = 1;
            const int QUA = 2;

            DiasDaSemana primeiroDia = DiasDaSemana.SEG;

            DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.TER | DiasDeTrabalho.QUI | DiasDeTrabalho.SEX;

            Console.WriteLine(diasDeTrabalho);
        }
    }

    enum DiasDaSemana : int {
        SEG = 3,
        TER = 10,
        QUA = 15,
        QUI,
        SEX,
        SAB,
        DOM
    }

    [Flags]
    enum DiasDeTrabalho {
        SEG = 0,
        TER = 1,
        QUA = 2,
        QUI = 4,
        SEX = 8,
        SAB = 16,
        DOM = 32
    }
}
