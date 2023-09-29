using System.ComponentModel;

namespace _2M_04_Ulamek
{
    class liczba
    {
        private int _id;
        public int getId()
        {
            return _id;
        }
        private void setId(int id)
        {
            this._id = id;
        }
    }
    class Ulamek
    {
        //private int licznik=0, mianownik=1;
        public int licznik { get; set; }
        private int _mianownik;
        public int mianownik {
            get
            {
                return this._mianownik;
            }
            set 
            {
                if(mianownik == 0)
                    this._mianownik = 1;
                else
                    this._mianownik = mianownik;

            } 
        }
        
        public Ulamek(int licznik=0, int mianownik=1)
        {
            int nwd = NWD(licznik, mianownik);
            this.licznik = licznik/nwd;
            this._mianownik = mianownik/nwd;
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
            u3.licznik = 10;
            u3.wypiszUlamek();
            Console.WriteLine(u3.licznik);

     
        }
    }
}