using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work6;

namespace Work6
{
    class Program
    {
        static void Main(string[] args)
        {

            // For abstract class
            Console.WriteLine("Полиморфизм (сложение длин строк):");
            Inventar skameika = new Skameika() { name="скамейка", count=8};
            string a = "Bed";
            Console.WriteLine($"\0{skameika.V_method(a.Length)}");
            Console.WriteLine();

            // For interface

            Brusia br = new Brusia() { name="брусья", count=3};
            string brusia2 = "Brusia";
            Console.WriteLine($"Реализация работы с интерфейсом:\0");
            Console.WriteLine($"\0сумма пар брусьев:\0{br.Summ(br.brusia, 4)}");
            Console.WriteLine($"\0сумма строк:\0{br.Summ(brusia2)}");
            Console.WriteLine();


            Console.WriteLine("Введите общее количество мячей:\0");
            int balls1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество мячей, которые вы можете предоставить:\0");
            int balls2 = Int32.Parse(Console.ReadLine());
            Ball ball = new Ball();
            Console.WriteLine($"\0сумма ваших мячей:\0{ball.Summ(balls1, balls2)}");
            Console.WriteLine($"\0произведение ваших мячей:\0{ball.Umn(balls1, balls2)}");
            Console.WriteLine();


            Console.WriteLine("Реализация работы с is:");
            Maty maty = new Maty() { name="маты", count=10};
            Console.Write("\0принадлежит ли созданный объект maty классу Ball:\0");
            maty.Proverka(maty);
            Console.WriteLine();


            Tennis one = new Tennis();
            Console.WriteLine("Переопределенные методы:\0");
            Console.WriteLine($"\0Equals:\0{one.Equals("Table")};");
            Console.WriteLine($"\0GetHashCode:\0{one.GetHashCode()};");
            Console.WriteLine($"\0ToString:\0{one.ToString()};");
            Console.WriteLine();


            Console.WriteLine("Информация о классах:\0");
            Console.WriteLine(skameika.ToString());
            Console.WriteLine(br.ToString());
            Bask_ball bas = new Bask_ball();
            Console.WriteLine(bas.ToString());
            Console.WriteLine();


            Console.WriteLine($"Работа класса Printer:\0");

            Inventar[] array = new Inventar[4];
            array[0] = skameika;
            array[1] = maty;
            array[2] = ball;
            array[3] = br;

            Printer pr = new Printer();

            for (int i = 0; i < 4; i++)
            {
                pr.iAmPrinting(array[i]);
            }
            Console.WriteLine();


            Console.WriteLine("Работа со структурой:");
            Zal zal;
            zal.thing = "мяч";
            zal.count = 6;
            zal.Print();
            Console.WriteLine();

            Console.WriteLine("Работа с перечислением:");
            AllThings things;
            things = AllThings.table;
            Console.WriteLine($"Количество столов:\0{(int)things}");
            Console.WriteLine();

            Console.WriteLine("Работа с контейнером:");
            Container_for_Zal cont = new Container_for_Zal();
            cont.Push(skameika);
            cont.Push(br);
            cont.Push(maty);

            Console.WriteLine("\tВесь список вещей:\0");
            cont.Show();

            cont.Delete(br);
            Console.WriteLine("\tСписок вещей после удаления одной из них:\0");
            cont.Show();
            Console.WriteLine();
            Console.Write("\0Общее количество вещей:\0");
            cont.Count_();
            Console.WriteLine();


            Console.WriteLine("Работа с контроллером:");
            Controller cont1 = new Controller(cont);
            cont1.Sort();
            

        }


        struct Zal
        {
            public string thing;
            public int count;

            public Zal (string thing, int count)
            {
                this.thing = thing;
                this.count = count;
            }

            public void Print()
            {
                Console.WriteLine($"\0Название предмета:\0{thing};\0число предметов:\0{count}");
            }


        }

        enum AllThings
        {
            Ball=1, skameika, table
        }


        public abstract class Inventar : Interface1
        {

            public string name;
            public int count;

            public string one = "Inventar";

            virtual public int V_method(int a)
            {
                return (one.Length + a);
            }

            public int Summ(int a, int b)
            {
                return a + b;
            }

            public string Summ(string a)
            {
                return a + one;
            }

            public void Print_()
            {
                Console.WriteLine($"\0Название предмета:\0{name};\0число предметов:\0{count}");
            }
        }


        public partial class Skameika : Inventar
        {            
            public override string ToString()
            {
                return ($"\0Информация об объекте:\0{E},\0{E.Equals(6)},\0{E.GetHashCode()},\0{E.GetType()}");
            }
        }

        public partial class Skameika:Inventar
        {
            public int E = 28;

            public override int V_method(int a)
            {
                return (one.Length * a);
            }
        }


        class Brusia : Inventar
        {
            public int brusia = 6;
            public override string ToString()
            {
                return ($"\0Информация об объекте:\0{brusia},\0{brusia.Equals(6)},\0{brusia.GetHashCode()},\0{brusia.GetType()}");
            }
        }


        class Ball : Inventar, Interface2
        {

            public int Umn(int a, int b)
            {
                return a * b;
            }


            int Summ(int a, int b)
            {
                return a + b;
            }
                   
        }


        class Maty : Inventar
        {
            public void Proverka(object a)
            {
                Console.WriteLine(a is Ball);
            }
        }


        class Bask_ball : Ball
        {
            public int bask = 17;
            public override string ToString()
            {
                return ($"\0Информация об объекте:\0{bask},\0{bask.Equals(6)},\0{bask.GetHashCode()},\0{bask.GetType()}");
            }
        }

        // Sealed

        sealed class Tennis : Inventar
        {
            public string one = "Tennis";

            public override bool Equals(object obj)
            {
                Tennis word = new Tennis();
                return (word.one == (string)obj);
            }

            public override int GetHashCode()
            {
                return one.GetHashCode();
            }

            public int two = 10;

            public override string ToString()
            {
                return two.ToString();
            }


        }


        class Printer : Inventar
        {
            public virtual void iAmPrinting(Inventar invent)
            {
                Console.WriteLine(invent.GetType());
                Console.WriteLine(invent.ToString());
            }
        }




        class Container_for_Zal
        {
            
            public List<Inventar> cont;

            public Container_for_Zal()
            {
                cont = new List<Inventar>();
            }


            public void Push(Inventar El)
            {
                cont.Add(El);
            }

            public void Delete(Inventar El)
            {
                for (int i = 0; i < cont.Count; i++)
                {
                    if (El.Equals(cont[i]))
                    {
                        cont.RemoveAt(i);
                    }
                }
            }

            public void Show()
            {
                for (int i = 0; i < cont.Count; i++)
                {
                    cont[i].Print_();
                }
                Console.WriteLine();
            }

            public void Count_()
            {
                int Count = 0;
                for (int i = 0; i < cont.Count; i++)
                {
                    Count = Count + cont[i].count;
                }
                Console.WriteLine($"{Count}");
            }
        }


        
        }
    }
}

