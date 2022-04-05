using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie1
{
    class Machine
    {
        private List<string> tokens;

        public Machine()
        {
            tokens = new List<string>();
        }

        public List<string> ShowAll()
        {
            return tokens; //pokazywanie calej listy
        }

        public void AddToken(string token)
        {
            tokens.Add(token); //dodawanie kolejnego kuponu
        }

        public Boolean IsMachineEmpty()
        {
            // Czy maszyna jest pusta?
            if (tokens.Count == 0)
                return true;
            else 
                return false;
        }

        public string GetRandomToken()
        {
            //losowanie kuponu
            Random rnd = new Random();
            int index = rnd.Next(0, tokens.Count);
            return tokens[index];
        }
    }
}
