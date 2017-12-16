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

                //result = int.Parse(liczba);

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

        public static double inputDouble(string inputText, double min, double max)
        {
            double result = 0.0f;

            while (true)
            {
                string liczba = Toolbox.inputString(inputText, false);

                result = double.Parse(liczba);

                if (!double.TryParse(liczba, out result) ||
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

                if (isEmpty) return result;
                else if (string.IsNullOrEmpty(result)) Console.WriteLine("Wartosc nie moze byc pusta!");
                else return result;
            }
        }

        public static string inputEmail(string inputText, bool isEmpty = false)
        {            
            while(true)            
            {
                string result = Toolbox.inputString(inputText, isEmpty);
                if (!new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(result))
                    {
                        Console.WriteLine("Podany adres nie jest poprawny!\nPrawidłowy format adresu to np.: john@smith.com");
                    }
                    else return result;                    
            }             
        }
        public static string inputEmail()
        {
            return inputEmail("Podaj adres e-mail: ", false);
        }



        public static string inputPostCode(string inputText, bool isEmpty = false)
        {
            while (true)
            {
                string result = Toolbox.inputString(inputText, isEmpty);
                if (result.Length != 6) Console.WriteLine("Kod musi posiadać 6 znaków!");
                else if (result.Substring(2, 1) != "-") Console.WriteLine("Nieprawidłowy format kodu! Poprawny format to 00-000");
                else
                {
                    uint postCodePart1, postCodePart2;
                    if (uint.TryParse((result.Remove(2, 4)), out postCodePart1) && uint.TryParse((result.Remove(0, 3)), out postCodePart2)) return result;
                    else Console.WriteLine("W kodzie mogą znajdować się tylko znaki [0-9] oraz [-]!");
                }
            }
        }
        public static string inputPostCode()
        {
            return inputPostCode("Podaj kod pocztowy: ", false);
        }
    }
}
