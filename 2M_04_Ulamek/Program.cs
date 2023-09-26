using System.ComponentModel;

namespace _2M_04_Ulamek
{
    class Ulamek
    {
        private int licznik=0, mianownik=1;
        public Ulamek()
        {
            licznik = 0;
            mianownik = 1;
        }
        public Ulamek(int licznik)
        {
            this.licznik = licznik; 
            mianownik = 1;
        }
        public Ulamek(int licznik, int mianownik)
        {
            int nwd = NWD(licznik, mianownik);
            this.licznik = licznik/nwd;
            this.mianownik = mianownik/nwd;
        }
        public void wypiszUlamek()
        {
            Console.WriteLine($"{licznik}/{mianownik}");
        }
        private int NWD(int a, int b)
        {
            int p = a % b;
            return p;
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