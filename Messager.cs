using System;
using System.Collections.Generic;

namespace Task1
{
    class Messager
    {       
        public void PrintMessage(IEnumerable<string> foldedLines)
        {           
            foreach (string rangeVariable in foldedLines)
            {
                Console.WriteLine(rangeVariable);
            }           
        }
    }
}
