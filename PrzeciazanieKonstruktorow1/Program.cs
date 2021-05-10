using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieKonstruktorow1
{
    class Program
    {
        //Napisz klasę zawierającą dwa pola: pierwsze typu double i drugie typu char (np.liczba i znak).
        //Dopisz pięć przeciążonych konstruktorów: pierwszy przyjmujący jeden argument typu double, drugi 
        //przyjmujący jeden argument typu char, trzeci przyjmujący dwa argumenty — pierwszy typu double, drugi 
        //typu char — i czwarty przyjmujący również dwa argumenty typu typu double. Czwarty konstruktor niech liczy 
        //NWD Euklidesa.Piąty konstruktor (przyjmuje tablice int) Sito Erastotenesa – liczby pierwsze

        static void Main(string[] args)
        {
            int[] liczby = new int[50];
            for(int i=0; i<liczby.Length; i++)
            {
                liczby[i] = i;
            }
            PrzeciazanieKonstruktorow przeciazanie1 = new PrzeciazanieKonstruktorow(5.8);
            PrzeciazanieKonstruktorow przeciazanie2 = new PrzeciazanieKonstruktorow('T');
            PrzeciazanieKonstruktorow przeciazanie3 = new PrzeciazanieKonstruktorow(16.8,'Z');
            PrzeciazanieKonstruktorow przeciazanie4 = new PrzeciazanieKonstruktorow(78, 48);
            //PrzeciazanieKonstruktorow przeciazanie4_1 = new PrzeciazanieKonstruktorow(0, 0);
            PrzeciazanieKonstruktorow przeciazanie5 = new PrzeciazanieKonstruktorow(liczby);
            
            Console.ReadKey();
        }
    }

    class PrzeciazanieKonstruktorow
    {
        private double liczba;
        private char znak;

        public PrzeciazanieKonstruktorow(double liczba)
        {
            this.liczba = liczba;
            Console.WriteLine(this.liczba);
        }
        public PrzeciazanieKonstruktorow(char znak)
        {
            this.znak = znak;
            Console.WriteLine(this.znak);
        }
        public PrzeciazanieKonstruktorow(double liczba, char znak)
        {
            this.liczba = liczba;
            this.znak = znak;
            Console.WriteLine("{0} {1}",this.liczba,this.znak);
        }
        public PrzeciazanieKonstruktorow(double l1, double l2)
        {
            //NWD Euklidesa
            double NWD = 0;
            double reszta = 1;
            if (l2 == 0)
            {
                Console.WriteLine("Nie dzielimy przez zero");
            }
            else
            {
                while (reszta != 0)
                {
                    reszta = l1 % l2;
                    if (reszta == 0)
                    {
                        NWD = l2;
                    }
                    else
                    {
                        l1 = l2;
                        l2 = reszta;
                    }
                }

                Console.WriteLine("NWD: {0}", NWD);
            }
        }
        public PrzeciazanieKonstruktorow(int[] tab)
        {
            //sito Erastotenesa - liczby pierwsze
            int j;

            for(int i = 2; i*i  <= tab.Length - 1; i++)
            {
                if(tab[i] != 0)
                {
                    j = i + i;
                    while(j <= tab.Length - 1)
                    {
                        tab[j] = 0;
                        j += i;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze: ");
            for(int i=2; i<= tab.Length -1; i++)
            {
                if(tab[i]!=0)
                    Console.Write(i + ", ");
            }
        }
    }
}
