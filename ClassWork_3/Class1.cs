using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_3 // В одном проекте - один namespace, исключение - библиотеки
{
    public class Class2 
    { 
        public void Method(Class1 obj) { obj.Method2(this); } // Передаём ссылку this в Method2
    }
    public partial class Class1 // partial для разграничения описания класса между файлами, как хэдеры в С++
    {
        public string Name;
        public static string Surname;
        public const string Asd = "asd"; // Константу надо сразу при объявлении проинициализировать
        public readonly string Wasd; // Это константа, которую мы можем не инициализировать, в отличии от const

        // Методы при создании надо сразу же прописывать, так как в C# нет заголовочных и исполняемых файлов, вс1 в одном файле
        public string Hellow(string name) { return name; }
        public void Method2(Class2 obj) { }
        public void Method3(ref int a, out int b) // ref - мы засовываем ссылку (проинициализированную),
         // out - мы возвращаем ссылку, которая даже у void ф.что-то возвращает/изменяет. Перменная по out м.б. неинициализированна
        { // Данная ф. изменяет по ссылке значение переменной b
            b = a;
        }
        public Class1(string Name) // Конструктор, можно без аргументов. this также используется для передачи ссылки на нынешний класс в другой класс
        {  
            this.Name = Name;
        }
        public Class1() { } // Дополнительный конструктор, если нам нужен пустой конструктор
    }
}
