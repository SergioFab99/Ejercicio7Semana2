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
    }
