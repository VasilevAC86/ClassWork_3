using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_3
{
    internal class Studen
    {
        public Studen(string surname, string group, int age) 
        {
            this._group = group;
            this._age = age;
            this._surname = surname;
            Random r = new Random();
            for (int i = 0; i < 3; ++i)
            {
                _data[i] = new int[5];
                for (int j = 0; j < 5; ++j)
                {
                    _data[i][j] = r.Next(1, 5);
                }
            }
        }
        public string Name() { return this._surname; }
        public string Group() { return this._group; }
        public int Age() { return this._age; }
        
        

        private string _surname;
        private string _group;
        private int _age;
        public int[][] _data = new int[3][];        
    }
}

