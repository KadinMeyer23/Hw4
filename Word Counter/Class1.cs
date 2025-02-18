//Kadin Meyer 2/18/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Word_Counter
{
    public class Count
    {

        public int word_count(string Sentence) {
            int total = 1;

            foreach (char c in Sentence)
            {
                if (c != ' ') continue;
                else { total++; }
            }


            return total;
        }

    }
}
