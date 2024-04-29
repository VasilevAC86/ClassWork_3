using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_3
{
    internal class Class3
    {
        private int _num;
        public int Num { get { return _num; } set { _num = value; } } // Первый способ объявления св-в класса (get и set)
        public string Asd2 { get; set; } // Второй самый распространённый способ объявление св-в класса (private поле Asd2 создаётся автоматически)
        // Ещё это называется "автосвойство"
        public void Der(int num = 12, params int[] cow) { } // params - ключевое слово о том, что может быть любое кол-во аргументов
    }
}
