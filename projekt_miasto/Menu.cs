using projekt_miasto.Motoryzacja.Samochody.ModelePojazdow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Menu
    {
        public static void StartMenu()
        {
            Osoba osoba = Osoba.StworzOsobe();            

            do
            {
                Console.Clear();
                Console.WriteLine(
                    "[1] Stworz zwierzaka.\n[2] Adoptuj zwierzaka.\n[3] Kup pojazd.\n[4] Jedz na przejazdzke.\n");
                int caseSwitch = Toolbox.inputInteger("Twoj wybor: ", 1, 4);

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine(
                            "[1] Kot\n[2] Pies\n\n[0] wyjscie\n\n");
                        int rodzajZwierza = Toolbox.inputInteger("Kot czy pies?: ", 0, 2);
                        switch (rodzajZwierza)
                        {
                            case 1:
                                Console.WriteLine(
                                    "[1] Bengalski\n[2] Mine Coon\n[3] Norweski Lesny\n[4] Syberyjski\n\n[0] wyjscie");
                                int rasaKota = Toolbox.inputInteger("Wybierz rase: ", 1, 4);
                                switch (rasaKota)
                                {
                                    case 1:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyKotow.Bengalski(
                                            Toolbox.inputString("Podaj imie kota: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 25)));
                                        break;
                                    case 2:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyKotow.MainCoon(
                                            Toolbox.inputString("Podaj imie kota: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 25)));
                                        break;
                                    case 3:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyKotow.NorweskiLesny(
                                            Toolbox.inputString("Podaj imie kota: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 25)));
                                        break;
                                    case 4:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyKotow.Syberyjski(
                                            Toolbox.inputString("Podaj imie kota: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 25)));
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            case 2:
                                Console.WriteLine(
                                    "[1] Buldog Francuski\n[2] Jamnik\n[3] Labrador\n[4] York\n\n[0] wyjscie\n\n");
                                int rasaPsa = Toolbox.inputInteger("Wybierz rase: ", 0, 4);
                                switch (rasaPsa)
                                {
                                    case 1:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyPsow.BuldogFrancuski(
                                            Toolbox.inputString("Podaj imie psa: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 30)));
                                        break;
                                    case 2:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyPsow.Jamnik(
                                            Toolbox.inputString("Podaj imie psa: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 30)));
                                        break;
                                    case 3:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyPsow.Labrador(
                                            Toolbox.inputString("Podaj imie psa: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 30)));
                                        break;
                                    case 4:
                                        Zwierzyniec.Instancja().DodajZwierzatko(new Zwierzaki.RasyPsow.York(
                                            Toolbox.inputString("Podaj imie psa: ", false),
                                            Toolbox.inputInteger("Podaj wiek kota: ", 1, 30)));
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;

                        }
                        break;


                    case 2:                        
                            Console.WriteLine("Lista Zwierzakow:");
                            Zwierzyniec.Instancja().WyswietlInformacje();
                            osoba.AdoptujZwierza(Zwierzyniec.Instancja().PobierzZwierzatko(
                                Toolbox.inputInteger("Podaj nr zwierzaka ktorego chcesz adoptowac: ", 1, 99)));                        
                        break;
                    
                    
                    case 3:                        
                            Console.WriteLine(
                                "[1] BMW X5\n[2] Jaguar XF\n[3] Opel Vivaro\n\n[0] wyjscie\n\n");
                            int rodzajPojazdu = Toolbox.inputInteger("Jakiego pojazdu potrzebujesz? ", 0, 3);
                            switch (rodzajPojazdu)
                            {
                                case 1:
                                    osoba.KupPojazd(new BMWX5());
                                    break;
                                case 2:
                                    osoba.KupPojazd(new JaguarXF());
                                    break;
                                case 3:
                                    osoba.KupPojazd(new OpelVivaro());
                                    break;
                                case 0:
                                    break;
                                default:
                                    break;
                            }                        
                        break;


                    case 4:
                        if (osoba.Samochody.Count() <= 0)
                        {
                            Console.WriteLine("Nie masz jeszcze zadnego samochodu - kup sobie jakis!");
                            goto case 3;
                        }
                        else
                        {
                            osoba.Samochody.ElementAt(Toolbox.inputInteger("Ktorego samochodu chcesz uzyc? ", 1, osoba.Samochody.Count())-1).JedziemyWSinaDal();
                        }
                        break;
                    case 0:
                        break;

                    default:
                        break;
                }

            } while (true);            
        }
    }
}
