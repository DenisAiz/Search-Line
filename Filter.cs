using System.Collections.Generic;
using System.Linq;
using System;

namespace Task1
{
    class Filter
    {      
        public IEnumerable<string> RowsFiltering(List<string> reReadText, string searchWord)
        {           
            var foldedLines = from rangeVariable in reReadText
                               where rangeVariable.Contains(searchWord)
                               select rangeVariable;           

            return foldedLines;
        }
    }
}
