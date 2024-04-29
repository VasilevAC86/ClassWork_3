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
        }
    }
}
