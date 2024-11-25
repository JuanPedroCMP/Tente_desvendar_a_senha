using static System.Console;

namespace Tente_desvendar_a_senha
{
    public class Program
    {
        public static int Dificuldade { get; set; }

        static void Main(string[] args)
        {
            WriteLine("Seja bem vindo!");
            Thread.Sleep(500);
            Clear();
            Write("\n\n\n");
            Write(@"    ▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ █▀▀   ▄▀█   █▀ █▀▀ █▄░█ █░█ ▄▀█
    █▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ ██▄   █▀█   ▄█ ██▄ █░▀█ █▀█ █▀█");
            Thread.Sleep(150);
            Write("\n\t\t Precione qualque tecla para continuar...");
            ReadKey(true);
            bool deuCerto = true;
            int opc;
            do
            {
                Clear();
                Write(@"
    ╔═════════════════════════════════╗
    ║           DIFICULDADE           ║
    ╠═════════════════════════════════╣
    ║        [1] Fácil (QD = 4)       ║
    ║        [2] Médio (QD = 6)       ║
    ║        [3] Dificíl (QD = 9)     ║
    ╚═════════════════════════════════╝
    QD = Quandidade de dígitos
");
                Write("\n    Faça a sua escolha (digite o número correspondente): ");

                deuCerto = int.TryParse(ReadLine(), out opc);
            } while (!deuCerto);
            do
            {
                deuCerto = true;
                switch (opc)
                {
                    case 1: Dificuldade = 4; break;
                    case 2: Dificuldade = 6; break;
                    case 3: Dificuldade = 9; break;
                    default: deuCerto = false; break;
                }
            } while (!deuCerto);
        }

        static void adivinhar()
        {
            int senha;
            bool deuCerto = true;
            Random Rnd = new();
            if (Dificuldade == 4) { senha = Rnd.Next(0, 9999); }
            else if (Dificuldade == 6) { senha = Rnd.Next(0, 999999); }
            else { senha = Rnd.Next(0, 999999999); }

            string senhaString = Convert.ToString(senha);
            string palpiteString = "";

            SetCursorPosition(4, 4);
            Write(new string('_', Dificuldade));
            SetCursorPosition(4, 6);
            Write("Insira a senha");
            while (!deuCerto)
            {
                palpiteString = ReadLine();
                deuCerto = int.TryParse(palpiteString, out int palpiteInt);
                if (palpiteString.Length != Dificuldade) { deuCerto = false; }
            }

            foreach (char PC in palpiteString)
            {
                bool contem = senhaString.Contains(PC);
                if (contem)
                {
                    foreach (char SC in senhaString)
                    {
                        bool contem2 = false;
                        if (PC == SC) { contem2 = true; }


                    }
                }


            }
        }
    }
}