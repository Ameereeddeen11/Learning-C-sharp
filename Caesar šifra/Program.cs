﻿using System;
using System.ComponentModel.DataAnnotations;

namespace caesorsifra
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = false;
            while (!run)
            {
                // nastaveni promenych
                string odpoved;
                string text;
                string posun;

                // cteni textu pro sifrovani
                Console.WriteLine("chcete šifrovat napište: 1");
                Console.WriteLine("chcete dešifrovat napište: 2");
                odpoved = Console.ReadLine();
                Console.WriteLine("zadejte text:");
                text = Console.ReadLine();
                Console.WriteLine("zadejte posun:");
                posun = Console.ReadLine();

                // urceni zda se jedna o sifrovani nebo desifrovani
                if (odpoved == "1")
                {
                    Sifrace.Sifrovani(Validation.IsValidText(text), Validation.IsValidPosun(posun));
                }
                else if (odpoved == "2")
                {
                    Sifrace.Desifrovani(Validation.IsValidText(text), Validation.IsValidPosun(posun));
                }
                else
                {
                    Console.WriteLine("Dali jste šptnou hodnotu nebo jste neuvedli žadnou hodnotu");
                    run = false;
                }

                // urceni zda chce uzivatel pokracovat
                Console.WriteLine("chcete pokračovat? ano = 1 ne = 0");
                string odpoved2 = Console.ReadLine();
                if (odpoved2 == "1")
                {
                    run = false;
                }
                else if (odpoved2 == "0")
                {
                    run = true;
                }
                else
                {
                    Console.WriteLine("tanto možnost neexistuje");
                    run = true;
                }
            }
        }        
    }

    /*class Sifrovani
    {
        // metodan pro sifrovani a desifrovani
        static void Sifrovani(string text, string posun)
        {
            string output = "";
            int posunNumber = Convert.ToInt32(posun);
            foreach (char pismeno in text)
            {
                if (char.IsLetter(pismeno))
                {
                    char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';
                    output = output + (char)(((pismeno + posunNumber - baseChar) % 26 + 26) % 26 + baseChar);
                }
                else if (char.IsDigit(pismeno))
                {
                    char baseChar = char.IsDigit(pismeno) ? '0' : '0';
                    output = output + (char)(((pismeno + posunNumber - baseChar) % 10 + 10) % 10 + baseChar);
                }
                else if (char.IsWhiteSpace(pismeno))
                {
                    output = output + " ";
                }
            }
            Console.WriteLine(output);
        }

        // metoda pro desifrovani
        static void Desifrovani(string text, string posun)
        {
            string output = "";
            int posunNumber = int.Parse(posun);
            foreach (char pismeno in text)
            {
                if (char.IsLetter(pismeno))
                {
                    char baseChar = char.IsUpper(pismeno) ? 'A' : 'a';
                    output = output + (char)(((pismeno - posunNumber - baseChar) % 26 + 26) % 26 + baseChar);
                }
                else if (char.IsDigit(pismeno))
                {
                    char baseChar = char.IsDigit(pismeno) ? '0' : '0';
                    output = output + (char)(((pismeno - posunNumber - baseChar) % 10 + 10) % 10 + baseChar);
                }
                else if (char.IsWhiteSpace(pismeno))
                {
                    output = output + " ";
                }
            }
            Console.WriteLine(output);
        }
    }

    class Validace
    {
        // kontrola zda uzivatel neco zadal
        static string IsValidText(string text)
        {
            bool valid = false;
            while (!valid)
            {
                string textWithoutSpace = text.Replace(" ", "");
                if (text.Length == 0 || textWithoutSpace.Length == 0)
                {
                    Console.WriteLine("nic jste nezadali text");
                    Console.WriteLine("Zadejte něco?");
                    text = Console.ReadLine();
                }
                else
                {
                    valid = true;
                }
            }
            return text;
        }

        // kontrola zda uzivatel neco posun
        static string IsValidPosun(string posun)
        {
            int b;
            bool valid = false;
            while (!valid)
            {
                bool res = int.TryParse(posun, out int result);
                string posunWithoutSpace = posun.Replace(" ", "");
                if (posunWithoutSpace.Length == 0 && res == false)
                {
                    Console.WriteLine("nezadali jste posun");
                    Console.WriteLine("zadejte posun:");
                    posun = Console.ReadLine();
                }
                else
                {
                    valid = true;
                }
            }
            return posun;
        }
    }*/
}