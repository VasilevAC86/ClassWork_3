using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_3
{
    struct Article
    {
        public int id; // код товара
        public string title; // название товара
        public int price; // Цена товара
        public ArticleType Type; // Поле для перечисления
        public Article(int id, string title, int price, ArticleType type) 
        { 
            this.id = id;
            this.title = title;
            this.price = price;
            this.Type = type;
        }
    }
    public enum ArticleType
    {
        Type1,
        Type2,
        Type3
    }
    struct Client
    {
        public int id; // код клиента
        string surname; // ФИО
        string adress; // адресс
        int phone; // номер телефона
        int num_order; // кол-во заказов
        float sum_order; // Сумма заказов
        public ClientType Type; // Поле для перечисления
        public Client(int id, string surname, string adress, int phone, int num_order, float sum_order, ClientType type)
        {
            this.id = id;
            this.surname = surname;
            this.adress = adress;
            this.phone = phone;
            this.num_order = num_order;
            this.sum_order = sum_order;
            this.Type = type;
        }
    }
    public enum ClientType
    {
        VIP,
        High,
        Middle,
        Low
    }
    internal class Class3
    {
        private int _num;
        public int Num { get { return _num; } set { _num = value; } } // Первый способ объявления св-в класса (get и set)
        public string Asd2 { get; set; } // Второй самый распространённый способ объявление св-в класса (private поле Asd2 создаётся автоматически)
        // Ещё это называется "автосвойство"
        public void Der(int num = 12, params int[] cow) // params - ключевое слово о том, что может быть любое кол-во аргументов
        {
            Article article1 = new Article(1, "Товар 1", 100, ArticleType.Type1);
            Client client1 = new Client(1, "Вася Пупкин", "Бомж", 12345679, 123, 8.5f, ClientType.Low);
        } 
        
    }
}
