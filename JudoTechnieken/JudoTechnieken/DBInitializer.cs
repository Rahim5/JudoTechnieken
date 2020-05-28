using JudoTechnieken.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class DBInitializer
    {
       
        public static void Initialize(JudoContext context)
        {
            Random r = new Random();
            context.Database.EnsureCreated();

            Gordel g1 = null;
            Gordel g2 = null;
            Gordel g3 = null;
            Gordel g4 = null;
            Gordel g5 = null;
            Gordel g6 = null;
            Gordel g7 = null;
            
            if (!context.Gordels.Any())
            {
                 g1 = new Gordel()
                {
                    Kleur = "wit",
                    Graad = "6e kyu",
                    nodigeLeeftijd = 4,

                };
                 g2 = new Gordel()
                {
                    Kleur = "geel",
                    Graad = "5e kyu",
                    nodigeLeeftijd = 6,

                };
                 g3 = new Gordel()
                {
                    Kleur = "oranje",
                    Graad = "4e kyu",
                    nodigeLeeftijd = 8,

                };
                 g4 = new Gordel()
                {
                    Kleur = "groen",
                    Graad = "3e kyu",
                    nodigeLeeftijd = 10,

                };
                 g5 = new Gordel()
                {
                    Kleur = "blauw",
                    Graad = "2e kyu",
                    nodigeLeeftijd = 12,

                };
                 g6 = new Gordel()
                {
                    Kleur = "bruin",
                    Graad = "1e kyu",
                    nodigeLeeftijd = 14,

                };
                 g7 = new Gordel()
                {
                    Kleur = "zwart",
                    Graad = "1e dan",
                    nodigeLeeftijd = 16,

                };
                context.Gordels.Add(g1);
                context.Gordels.Add(g2);
                context.Gordels.Add(g3);
                context.Gordels.Add(g4);
                context.Gordels.Add(g5);
                context.Gordels.Add(g6);
                context.Gordels.Add(g7);

              
            }

            if (!context.Technieken.Any())
            {
                var t1 = new Techniek()
                {
                    Naam = "o-soto-gari",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g1,
                };
                var t2 = new Techniek()
                {
                    Naam = "de-ashi-barai",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel=g1,
                };
                var t3 = new Techniek()
                {
                    Naam = "hiza-guruma",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "gemiddeld",
                    Gordel = g1,
                };
                var t4 = new Techniek()
                {
                    Naam = "ko-soto-gake",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "moeilijk",
                    Gordel = g2,
                };
                var t5 = new Techniek()
                {
                    Naam = "o-uchi-gari",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g2,
                };
                var t6 = new Techniek()
                {
                    Naam = "ko-uchi-gari",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g2,
                };
                var t7 = new Techniek()
                {
                    Naam = "o-soto-guruma",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "gemiddeld",
                    Gordel = g4,
                };
                var t8 = new Techniek()
                {
                    Naam = "o-soto-otoshi",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "moeilijk",
                    Gordel = g4,
                };
                var t9 = new Techniek()
                {
                    Naam = "ko-soto-gari",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g4,
                };
                var t10 = new Techniek()
                {
                    Naam = "sasae-tsuri-komi-ashi",
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g4,
                };
                var t11 = new Techniek()
                {
                    Naam = "kata-seoi",
                    Type = "schouderworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g6,
                };
                var t12 = new Techniek()
                {
                    Naam = "seoi-nage",
                    Type = "schouderworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g6,
                };
                var t13 = new Techniek()
                {
                    Naam = "kata-guruma",
                    Type = "schouderworp",
                    Moeilijkheidsgraad = "gemiddeld",
                    Gordel = g6,
                };
                var t14 = new Techniek()
                {
                    Naam = "seoi-otoshi",
                    Type = "schouderworp",
                    Moeilijkheidsgraad = "moeilijk",
                    Gordel = g6,
                };
                var t15 = new Techniek()
                {
                    Naam = "hidari-kata-seoi",
                    Type = "schouderworp",
                    Moeilijkheidsgraad = "moeilijk",
                    Gordel = g6,
                };
                var t16 = new Techniek()
                {
                    Naam = "uki-goshi",
                    Type = "heupworp",
                    Moeilijkheidsgraad = "gemiddeld",
                    Gordel = g7,
                };
                var t17 = new Techniek()
                {
                    Naam = "kubi-nage",
                    Type = "heupworp",
                    Moeilijkheidsgraad = "moeilijk",
                    Gordel = g7,
                };
                var t18 = new Techniek()
                {
                    Naam = "tsuri-goshi",
                    Type = "heupworp",
                    Moeilijkheidsgraad = "gemiddeld",
                    Gordel = g3,
                };
                var t19 = new Techniek()
                {
                    Naam = "koshi-guruma",
                    Type = "heupworp",
                    Moeilijkheidsgraad = "makkelijk",
                    Gordel = g3,
                };
                var t20 = new Techniek()
                {
                    Naam = "harai-goshi",
                    Type = "heupworp",
                    Moeilijkheidsgraad = "moeilijk",
                    Gordel = g2,
                };

                context.Technieken.Add(t1);
                context.Technieken.Add(t2);
                context.Technieken.Add(t3);
                context.Technieken.Add(t4);
                context.Technieken.Add(t5);
                context.Technieken.Add(t6);
                context.Technieken.Add(t7);
                context.Technieken.Add(t8);
                context.Technieken.Add(t9);
                context.Technieken.Add(t10);
                context.Technieken.Add(t11);
                context.Technieken.Add(t12);
                context.Technieken.Add(t13);
                context.Technieken.Add(t14);
                context.Technieken.Add(t15);
                context.Technieken.Add(t16);
                context.Technieken.Add(t17);
                context.Technieken.Add(t18);
                context.Technieken.Add(t19);
                context.Technieken.Add(t20);



            }

            if (!context.Personen.Any())
            {
                var p1 = new Persoon()
                {
                    Achternaam = "Meeuw",
                    Voornaam = "Jan",
                    Email = "Jan.Meeuw@hotmail.com",
                    Leeftijd = r.Next(6,60),
                    Hoogte= r.Next(160,200),
                    Gewicht=r.Next(60,120),
                    

                };
                var p2 = new Persoon()
                {
                    Achternaam = "Lianos",
                    Voornaam = "Peeters",
                    Email = "Peeters.Lianos@hotmail.com",
                    Leeftijd = r.Next(6, 60),
                    Hoogte = r.Next(160, 200),
                    Gewicht = r.Next(60, 120),
                  

                };
                var p3 = new Persoon()
                {
                    Achternaam = "Jacky",
                    Voornaam = "John",
                    Email = "John.Jacky@hotmail.com",
                    Leeftijd = r.Next(6, 60),
                    Hoogte = r.Next(160, 200),
                    Gewicht = r.Next(60, 120),
                  

                };
                var p4 = new Persoon()
                {
                    Achternaam = "Fineta",
                    Voornaam = "Kevin",
                    Email = "Kevin.Fineta@hotmail.com",
                    Leeftijd = r.Next(6, 60),
                    Hoogte = r.Next(160, 200),
                    Gewicht = r.Next(60, 120),
                    

                };
                context.Personen.Add(p1);
                context.Personen.Add(p2);
                context.Personen.Add(p3);
                context.Personen.Add(p4);
            }

            if (!context.UserInfo.Any())
            {
                var u1 = new UserInfo()
                {

                    FirstName = "Inventory",
                    LastName = "Admin",
                    UserName = "InventoryAdmin",
                    Email = "InventoryAdmin@abc.com",
                    Password = "$admin@2017"
                };
                context.UserInfo.Add(u1);
            }

            context.SaveChanges();

            




        }       
    }
}
