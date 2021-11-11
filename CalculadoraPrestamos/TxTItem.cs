using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPrestamos
{
    public class TxTItem
    {
        public string Texto { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}
