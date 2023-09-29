using System.ComponentModel;

namespace _2M_04_Ulamek
{
    class Ulamek
    {
        private int licznik=0, mianownik=1;

        public Ulamek(int licznik=0, int mianownik=1)
        {
            int nwd = NWD(licznik, mianownik);
            this.licznik = licznik/nwd;
            this.mianownik = mianownik/nwd;
        }

        public int getLicznik()
        {
            return licznik;
        }
        public void setLicznik(int licznik)
        {
           this.licznik = licznik;           
        }
        public void wypiszUlamek()
        {
            Console.WriteLine($"{licznik}/{mianownik}");
        }
        private int NWD(int a, int b)
        {
            int p = 1;

            while (p!=0)
            {
                p = a % b;
                a = b;
                b = p;
            }
            
            return a;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Ulamek u1 = new Ulamek();
            u1.wypiszUlamek();
            Ulamek u2 = new Ulamek(5);
            u2.wypiszUlamek();
            Ulamek u3 = new Ulamek(3,6);
            u3.wypiszUlamek();
        }
    }
}