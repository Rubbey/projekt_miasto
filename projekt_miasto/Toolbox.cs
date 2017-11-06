using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Toolbox
    {
        public static string BRAK_DANYCH = "Brak danych";

        public static int inputInteger(string inputText,int min, int max)
        {
            int result = 0;

            while (true)
            {
                string liczba = Toolbox.inputString(inputText, false);

                result = int.Parse(liczba);

                if (!int.TryParse(liczba, out result) ||
                    (result < min || result > max))
                {
                    Console.WriteLine("Wprowadzono niepoprawna wartosc (Zakres {0} {1})", min, max);
                }
                else
                    break;        
            }
            
            return result;
        }

        public static string inputString(string inputText, bool isEmpty)
        {
            string result = "";

            while(true)
            {
                Console.Write(inputText);
                result = Console.ReadLine();

                if (isEmpty)
                {
                    break;
                }                    
                else
                    if (string.IsNullOrEmpty(result))
                    {   
                        Console.WriteLine("Wartosc nie moze byc pusta!");
                    }
                    else
                        break;
            }

            return result;
        }

        public static string inputEmail(string inputText, bool isEmpty = false)
        {
            string result = "";
            bool validation = false;
            do
            {
                Console.Write(inputText);
                result = Console.ReadLine();
                

                if (isEmpty) break;
                else
                {
                    if (!new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(result))
                    {
                        Console.WriteLine("Podany adres nie jest poprawny!\nPrawidłowy format adresu to np.: john@smith.com");
                    }
                    else validation = true;
                    
                }
                
            } while (!validation);

            return result;
        }
    }
}
