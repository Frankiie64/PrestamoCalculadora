using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPrestamos.CustomComboBox
{
    public class ComboBoxItem
    {
        public string Texto { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}
