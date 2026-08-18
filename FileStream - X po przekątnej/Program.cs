
using System.IO;

class Program
{

    FileStream FIN, FOUT;

    public void czytaj_dane()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (i == 0 || i == 8 || i == j || j == 9 - 1 - i)
                {
                    Console.Write("X");

                }
                else
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine();
        }
    }

    public void zapisz_dane()
    {
        Console.WriteLine("Zapisuje do pliku przekatna.txt");   
        FOUT = new FileStream("przekatna.txt", FileMode.Create);
        StreamWriter zapisz = new StreamWriter(FOUT);
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (i == 0 || i == 8 || i == j || j == 9 - 1 - i)
                {
                    zapisz.Write("X");

                }
                else
                {
                    zapisz.Write(" ");
                }

            }
            zapisz.WriteLine();
        }
        zapisz.Close();
        FOUT.Close();

    }
    public void odczytaj_dane()
    {
        Console.WriteLine("Odczytuje z pliku przekatna.txt");   
        FIN = new FileStream("przekatna.txt", FileMode.Open);
        StreamReader odczyt = new StreamReader(FIN);
        string odczytaj;
        while ((odczytaj = odczyt.ReadLine()) != null)
        {
            Console.WriteLine(odczytaj);
        }
        odczyt.Close();
        FIN.Close();
    }










    static void Main(string[] args)
    {
        Program progam = new Program();
        progam.czytaj_dane();
        progam.zapisz_dane();
        progam.odczytaj_dane();

    }
}