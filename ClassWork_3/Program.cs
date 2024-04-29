namespace ClassWork_3
{
    internal class Program // internal класс не видим для других проектов
    {
        // 1. От структуры невозможно создать объект
        // 2. От структуры нельзя наследовать класс
        struct Name
        {
            public Name (string name) // Конструктор должен быть публичным
            {

            }
        }
        static void Main(string[] args) // Статические методы можно использовать без создания объекта
        {
            int a = 3; int b;
            Class1 cl = new Class1 (); // Создание объекта класса Class1 конструктором без аргумента
            cl.Method3(ref a, out b);
            Console.WriteLine(b);
            Class3 cl3 = new Class3 ();
            Console.WriteLine(cl3.Asd2); // Получаем доступ к автоматически созданному программой полю Asd2
           
            Studen s1 = new Studen("Вася Пупкин", "БВ322", 20);
            Console.WriteLine("ФИО = " + s1.Name());
            Console.WriteLine("Группа = " + s1.Group());
            Console.WriteLine("Возраст = " + s1.Age());
            Console.WriteLine("\n\nОценки по программированию: ");
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(s1._data[0][i] + "\t");
                num1 += s1._data[0][i];
            }
            Console.WriteLine("\n\nОценки по администрированию: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(s1._data[1][i] + "\t");
                num2 += s1._data[1][i];
            }
            Console.WriteLine("\n\nОценки по дизайну: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(s1._data[0][i] + "\t");
                num3 += s1._data[2][i];
            }
            Console.Write("\n\nСредняя оценка по программированию = " + (float)num1 / 5);
            Console.Write("\nСредняя оценка по администрированию = " + (float)num2 / 5);
            Console.Write("\nСредняя оценка по дизайну = " + (float)num3 / 5);
            Console.WriteLine();

        }
    }
}
