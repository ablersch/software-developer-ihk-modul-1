﻿using System;

namespace Medienverwaltung_Aufgabe_4
{
    class Medium
    {
        public Leihstatus leihstatus;
        public int signatur = 0;
        public string titel;
        public TypBezeichnung typ;

        public enum Leihstatus 
        {
            präsent,
            entliehen
        };

        public enum TypBezeichnung
        {
            Video,
            Buch
        };

        public Medium()
        {
            signatur = SignaturErzeugen();

            Console.WriteLine("Titel eingeben:");
            titel = Console.ReadLine();

            leihstatus = Leihstatus.präsent;
        }

        internal void Entleihen(int sig) {
            if (signatur == sig)
            {
                if (leihstatus == Leihstatus.präsent)
                {
                    leihstatus = Leihstatus.entliehen;
                    Console.WriteLine($"{titel} erfolgreich ausgeliehen");
                }
                else
                {
                    Console.WriteLine($"{titel} ist bereits entliehen");
                }
            }
        }

        internal void Rueckgabe(int sig) {
            if (signatur == sig)
            {
                if (leihstatus == Leihstatus.entliehen)
                {
                    leihstatus = Leihstatus.präsent;
                    Console.WriteLine($"{titel} efolgreich zurueckgegeben");
                }
                else
                {
                    Console.WriteLine($"Rueckgabe von {titel} nicht möglich da das Medium nicht entliehen ist");
                }
            }
        }

        private int SignaturErzeugen()
        {
            Random random = new Random();
            int newKey;
            do
            {
                newKey = random.Next(1000, 100000);
            } while (Program.medienDic.ContainsKey(newKey));

            return newKey;
        }
    }
}
