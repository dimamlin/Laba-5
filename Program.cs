using System;

namespace laba_6
{
    //Товар, Техника, Печатающее устройство, Сканер, Компьютер, Планшет.

    interface IInterface1 // одинаковый метод интерфейса и абстрактного класса
    {
        void Method1();
    }
    abstract class BaseClone
    {
        public abstract void Method1();
    }
    class SomeClass : BaseClone, IInterface1
    {
        void IInterface1.Method1()
        {
            Console.WriteLine("first");
        }
        public override void Method1()
        {
            Console.WriteLine("second");
        }
    }


    class A : Temp // переопределение 
    {
        public override string ToString()
        {         
            Console.WriteLine("Объекты класса Temp");
            Print();
            return "";
        }
    }

    class Temp
    {
        string nameWin = null;
        string nameCPU = null;
        int memory = 0;
        int RAM = 0;
        string nameAntiv = null;
        public Temp()
        {

            nameAntiv = "360 total security ";
            nameWin = "Windows 7";
            nameCPU = "Intel CORE i7";
            memory = 2;
            RAM = 10;
        }

        public void Print()
        {
 
            Console.WriteLine("OC: " + nameWin);
            Console.WriteLine("CPU: " + nameCPU);
            Console.WriteLine("hard drive: " + memory + "ТБ");
            Console.WriteLine("RAM: " + RAM + "ГБ");
            Console.WriteLine("Антивирус: " + nameAntiv);
            Console.WriteLine();
        }
    }


    interface Running
    {
        void Print();
    }

    class Printer : A, Running
    {

        public new void Print()
        {
            ToString();
        }

    }

    public interface product       // создаем интерфейс
    {
        void Sell();
    }

    public abstract class technics      // создаем абстрактный класс
    {
        public bool availability;     
    }

    sealed public class print_device : technics, product // создаем герметизированный класс
    {
        public int price = 100;
        public string color = "red";
        public int work_time = 5;
        public void Sell()
        {
            Console.Write("For sell!");
        }
    }

    public class scanner : technics, product
    {
        public int price = 100;
        public string color = "red";
        public int work_time = 5;
        public void Sell()
        {
            Console.Write("For sell!");
        }

    }

    public class tablet : technics, product
    {
        public int price = 100;
        public string color = "red";
        public int work_time = 5;
        public void Sell()
        {
            Console.Write("For sell!");
        }
    }

    // Лабораторная работа №6

    public enum Name { Mac, Windows, Linux }; // создаем перечисление

    public class computer : technics, product
    {
        public Name name;
        public computer(Name name) // конструктор, присваивает имя из перечисления
        {
            this.name = name;
        }
        public int price = 100;
        public string color = "red";
        public int work_time = 5;
        public void Sell()
        {
            Console.Write("For sell!");
        }
    }

    struct Rooms // структура комнаты
    {
        public int size;
    }

    public partial class Person // часть класса partial
    {
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }
    }

    public class Program
    {
        static void Runable(Running rn)
        {
            rn.Print();
        }

        static void main(string[] args)
        {
            var rn = new Printer();
            Runable(rn);
            Temp o = new Temp();
            if (o != null) o.ToString();
            computer pc_1 = new computer(Name.Mac); // создаем оъекты и присваиваем имя из перечисления
            computer pc_2 = new computer(Name.Windows);
            computer pc_3 = new computer(Name.Linux);
            Console.WriteLine(pc_1.name);
            Console.WriteLine(pc_2.name);
            Console.WriteLine(pc_3.name);
            Rooms a; // создаем объекты структуры 
            a.size = 1;
            Rooms b;
            b.size = 2;
            Rooms c;
            c.size = 3;
            Person tom = new Person(); // используем методы, определенные в разных файлах
            tom.Eat();
            tom.Move();
            //pc_1.price = 100;
            //Console.Write(pc_1 is object); // использование оператора is
            //SomeClass aa = new SomeClass();
            //Console.WriteLine();
            //((IInterface1)aa).Method1();
            //aa.Method1();
        }
    }
}
