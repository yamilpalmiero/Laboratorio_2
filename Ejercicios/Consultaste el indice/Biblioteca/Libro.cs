using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get
            {
                if (i <= paginas.Count)
                    return paginas[i];
                else
                    return "";
            }
            set
            {
                if (i < paginas.Count)
                    paginas[i] = value;

                else if (i == paginas.Count)
                    paginas.Add(value);
            }
        }
    }
}
