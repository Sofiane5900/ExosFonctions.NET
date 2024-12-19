using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // exo 01
            //void AffichagePrenom(string prenom, string nom)
            //{
            //    Console.WriteLine(prenom + " " + nom);
            //}

            //AffichagePrenom("Sofiane", "I");


            // exo 02
            //void Soustraction(int nombre_a, int nombre_b)
            //{
            //    Console.WriteLine($"Je soustrais {nombre_a} et {nombre_b} = {nombre_a - nombre_b}");
            //}
            //Soustraction(20, 50);

            // exo 03
            void WhatHours(string heure = "12h00")
            {
                Console.WriteLine($"Il est {heure}");
            }
            WhatHours("14h00");
        }
    }
}