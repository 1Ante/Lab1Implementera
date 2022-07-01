using System;

namespace Lab1Implementera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jag har implementerat designmönstren Factory Method, Singleton och Strategy i koden. Programmet 
            //är en enkel bankomat. 
            
            AlternativeContext context = new AlternativeContext();
            
            Console.WriteLine("Välkommen till bankomaten!");

            bool keepLooping = true;

            while(keepLooping == true)
            {
                Console.WriteLine();
                Console.WriteLine("Vilken valör vill du ta ut?");
                Console.WriteLine();
                Console.WriteLine("Meny. Välj siffra och tryck ENTER.");
                Console.WriteLine();
                Console.WriteLine("1. 100 SEK-sedel");
                Console.WriteLine("2. 200 SEK-sedel");
                Console.WriteLine("3. 500 SEK-sedel");                
                Console.WriteLine("4. 100 SEK i 20 SEK-sedlar");
                Console.WriteLine("5. 100 SEK i 10 SEK-kronor");
                Console.WriteLine("6. 200 SEK i 20 SEK-sedlar");
                Console.WriteLine("7. 200 SEK i 10 SEK-kronor");
                Console.WriteLine("8. 500 SEK i 20 SEK-sedlar");
                Console.WriteLine("9. 500 SEK i 10 SEK-kronor");
                Console.WriteLine("10. Avsluta programmet");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    //Factory Method
                    IValues value = new OneHunderedFactory().CreateMoney();
                    if (value != null)
                    {
                        Console.WriteLine("Du får 1 st " + value.GetValue() + " SEK-sedel");
                        Console.WriteLine();
                        Console.WriteLine("Visa menyn och gör ett nytt val genom att trycka på valfri tangent.");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                }
                else if (choice == "2")
                {
                    //Factory Method
                    IValues value = new TwoHunderedFactory().CreateMoney();
                    if (value != null)
                    {
                        Console.WriteLine("Du får 1 st " + value.GetValue() + " SEK-sedel");
                        Console.WriteLine();
                        Console.WriteLine("Visa menyn och gör ett nytt val genom att trycka på valfri tangent.");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                }
                else if (choice == "3")
                {
                    //Factory Method
                    IValues value = new FiveHunderedFactory().CreateMoney();
                    if (value != null)
                    {
                        Console.WriteLine("Du får 1 st " + value.GetValue() + " SEK-sedel");
                        Console.WriteLine();
                        Console.WriteLine("Visa menyn och gör ett nytt val genom att trycka på valfri tangent.");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                }
                else if (choice == "4")
                {
                    //Strategy
                    context.SetAlternativeStrategy(new TwentyBanknoteStrategy());
                    context.AlternativeValue(100);
                }
                else if (choice == "5")
                {
                    //Strategy
                    context.SetAlternativeStrategy(new TenCoinStrategy());
                    context.AlternativeValue(100);
                }
                else if (choice == "6")
                {
                    //Strategy
                    context.SetAlternativeStrategy(new TwentyBanknoteStrategy());
                    context.AlternativeValue(200);
                }
                else if (choice == "7")
                {
                    //Strategy
                    context.SetAlternativeStrategy(new TenCoinStrategy());
                    context.AlternativeValue(200);
                }
                else if (choice == "8")
                {
                    //Strategy
                    context.SetAlternativeStrategy(new TwentyBanknoteStrategy());
                    context.AlternativeValue(500);
                }
                else if (choice == "9")
                {
                    //Strategy
                    context.SetAlternativeStrategy(new TenCoinStrategy());
                    context.AlternativeValue(500);
                }
                else if(choice == "10")
                {
                    keepLooping = false;
                }                
                else
                {
                    Console.WriteLine("Fel. Välj siffra i menyn.");
                }              



            }         
           
        }
    }
}
