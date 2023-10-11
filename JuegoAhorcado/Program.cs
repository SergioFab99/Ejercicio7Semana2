using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    class Program
    {
        static void Main()
        {
            HangmanGame game = new HangmanGame();
            while (true)
            {
                game.StartNewGame();
                game.Play();

                Console.WriteLine("¿Quieres jugar de nuevo? (s/n)");
                string response = Console.ReadLine();
                if (response.ToLower() != "s")
                    break;
            }
        }
    }
}
