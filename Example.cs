Примеры выполнения заданий лабораторной работы

Пример 1. Описать класс «запись», содержащий следующие закрытые поля: фамилия, имя, номер телефона, дата рождения (массив из трех чисел).
Описать класс «записная книжка», содержащий закрытый массив записей. 
Написать программу, демонстрирующую все разработанные элементы классов.

using System;
using System.Collections.Generic;                              
namespace Zapis
{
    class Zapis {
       // закрытые члены класса: фамилия, имя, телефон, дата 
рождения
        private String _famil;
        private String _name;
        private String _telefon;
        private int[] _date = new int[3];
        private static int _KolZap;
        // конструстор класса
        public Zapis() {
            Famil = "";
            Name = "";
            Telefon = "";
            Date[0] = 0;
            Date[1] = 0;
            Date[2] = 0;
            _KolZap++;
        }
        // свойства для доступа к закрытым членам класса
        public String Famil {
            get { return _famil; }
            set { _famil = value; }
        }
        
   	  public String Name {
            get { return _name; }
            set { _name = value; }
        }
        public String Telefon {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public int[] Date {
            get { return _date; }
            set { _date = value; }
        }
        //статический метод, возвращающий количество записей
        public static int GetKolZap() {
            return _KolZap;
        }
        // метод для вывода информации о записи на экран
        public void print() {
Console.WriteLine("{0} {1}, родился {2}.{3}.{4}, его номер телефона:{5}", Name, Famil, Date[0], Date[1], Date[2], Telefon);
        }
    }
    
   class ZapisBook {
        // закрытый массив записей
        private Zapis[] _mass;       
        //конструктор класса, создает массив записей
        public ZapisBook(int KolZap) {
            _mass = new Zapis[KolZap];           
        }
        //индексатор для доступа к объекту класса
        public Zapis this[int index]  {
            get { return _mass[index]; }
            set { _mass[index] = value; }

        }
    }

    class Program
    {
        static void Main() {
            int _kolZap;
            Console.Write("Введите количество записей: ");
            _kolZap = int.Parse(Console.ReadLine());
            ZapisBook zp = new ZapisBook(_kolZap);
            // заполнение массива записей
            Zapis _currZap;
            for (int i = 0; i < _kolZap; i++) {
                _currZap = new Zapis();
        Console.WriteLine("Введите информацию по записи № {0}", i + 1);
                Console.Write("Фамилия: ");
                _currZap.Famil = Console.ReadLine();
                Console.Write("Имя: ");
                _currZap.Name = Console.ReadLine();
                Console.Write("Телефон: ");
                _currZap.Telefon = Console.ReadLine();
                Console.Write("День рождения: ");
                _currZap.Date[0] = int.Parse(Console.ReadLine());
                Console.Write("Месяц рождения: ");
                _currZap.Date[1] = int.Parse(Console.ReadLine());
                Console.Write("Год рождения: ");
                _currZap.Date[2] = int.Parse(Console.ReadLine());
                zp[i] = _currZap;
                Console.WriteLine("");
Console.WriteLine("Количество записей в записной книге = {0}", 
										Zapis.GetKolZap());
                     }
            
            Console.WriteLine("Список всех записей:\n");            
     		// вывод записей на экран
            for (int i = 0; i < _kolZap; i++) {                             
                zp[i].print();                                    
            } 
            Console.ReadLine();
        }
    }
}

