namespace Converter;

public class Currency
{
    public static void Run()
    {
        Console.WriteLine("Velg hvilken valuta du vil konvertere fra: 1. USD, 2. EUR, 3. GBP");
      
        string input = Console.ReadLine();
        if (input == "1")
        {
            Console.WriteLine("Skriv antall dollar du vil konvertere til kroner");
            double amount = Convert.ToDouble(Console.ReadLine());
        }
        else if (input == "2")
        {
            Console.WriteLine("Choose your currency: 1. USD, 2. EUR, 3. GBP");

        }
        else if (input == "3")
        {
            Console.WriteLine("Choose your currency: 1. USD, 2. EUR, 3. GBP");

        }
        else
        {
            Run();
        }
    

    }
}


// Converter
// Lag et program som kan konvertere valuta, temperatur eller vekt
// Du skal kunne få alternativer for hva du vil konvertere, velge hva du vil konvertere til,
// og så skrive inn en verdi før du får svar i konsollen.