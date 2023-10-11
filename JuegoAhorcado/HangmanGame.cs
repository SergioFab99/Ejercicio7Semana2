using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    class HangmanGame
    {
        private List<string> words = new List<string> { "tanaka", "rodrigo", "renzo", "andre" };
        private string currentWord;
        private List<char> guessedLetters;
        private int lives;
        public void StartNewGame()
        {
            Random random = new Random();
            currentWord = words[random.Next(words.Count)];
            guessedLetters = new List<char>();
            lives = 10;
        }
        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Juego del Ahorcado");
            Console.WriteLine("Por favor introduzca una letra");
            char[] wordToGuess = new char[currentWord.Length];

            while (lives > 0)
            {
                Console.WriteLine($"Palabra: {MaskedWord(wordToGuess)}");
                Console.WriteLine($"Vidas restantes: {lives}");
                Console.Write("Introduce una letra: ");
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("Ya has adivinado esa letra. Prueba otra.");
                    continue;
                }

                guessedLetters.Add(guess);

                if (currentWord.Contains(guess))
                {
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (currentWord[i] == guess)
                            wordToGuess[i] = guess;
                    }

                    if (currentWord == new string(wordToGuess))
                    {
                        Console.WriteLine($"¡Has ganado! La palabra era '{currentWord}'.");
                        return;
                    }
                }
                else
                {
                    lives--;
                    Console.WriteLine("Letra incorrecta. Pierdes una vida.");
                }
            }

            Console.WriteLine($"¡Has perdido! La palabra era '{currentWord}'.");
        }

        private string MaskedWord(char[] word)
        {
            string masked = new string(word);
            for (int i = 0; i < masked.Length; i++)
            {
                if (masked[i] == 0)
                    //Substring es un método que se utiliza para obtener una porción o fragmento
                    //de una cadena de texto existente,
                    //especificando la posición de inicio y, opcionalmente, la longitud de la subcadena.
                    masked = masked.Substring(0, i) + '_' + masked.Substring(i + 1);
            }
            return masked;
        }
    }
}