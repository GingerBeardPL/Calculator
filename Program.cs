using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba1, liczba2, wynik;
            char operacja;

            Console.WriteLine("Kalkulator");

            Console.Write("Podaj pierwszą liczbę: ");
            liczba1 = double.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            liczba2 = double.Parse(Console.ReadLine());

            Console.Write("Podaj rodzaj operacji (+, -, *, /): ");
            operacja = char.Parse(Console.ReadLine());

            switch (operacja)
            {
                case '+':
                    wynik = liczba1 + liczba2;
                    Console.WriteLine("Wynik dodawania: " + wynik);
                    break;
                case '-':
                    wynik = liczba1 - liczba2;
                    Console.WriteLine("Wynik odejmowania: " + wynik);
                    break;
                case '*':
                    wynik = liczba1 * liczba2;
                    Console.WriteLine("Wynik mnożenia: " + wynik);
                    break;
                case '/':
                    if (liczba2 == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez zero.");
                    }
                    else
                    {
                        wynik = liczba1 / liczba2;
                        Console.WriteLine("Wynik dzielenia: " + wynik);
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa operacja.");
                    break;
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
