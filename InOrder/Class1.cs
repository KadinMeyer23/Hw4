using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrder
{
    public class TF_orderCalculator
    {

        public bool TF_Teller(string sentence) {


            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if ((int)sentence[i] < (int)sentence[i + 1]) { continue; }
                else { return false; }
            }


            return true;
        }   




    }
}
