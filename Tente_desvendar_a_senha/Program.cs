using static System.Console;

namespace Tente_desvendar_a_senha
{
    internal class Program
    {
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
            Clear();
            Write(@"
    ╔═════════════════════════════════╗
    ║           DIFICULDADE           ║
    ╠═════════════════════════════════╣
    ║        [1] Fácil (QD = 4)       ║
    ║        [2] Médio (QD = 6)       ║
    ║        [3] Dificíl (QD = 10)    ║
    ╚═════════════════════════════════╝
    QD = Quandidade de dígitos
");


        }
    }
}
