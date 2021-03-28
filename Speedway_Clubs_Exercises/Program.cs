using System;
using System.Collections.Generic;

namespace Speedway_clubs
{
    class Program
    {
        static void Main(string[] args)
        {

            Clubs c1 = new Clubs();
            c1.Names = "Apator Toruń";
            c1.League = "Ekstraliga";
            c1.StartYear = "1962";


            Players p1 = new Players("Paweł", "Przedpełski");
            Players p2 = new Players("Chris", "Holder");
            Players p3 = new Players("Jack", "Holder");
            Players p4 = new Players("Adrian", "Miedziński");

            Clubs c2 = new Clubs("Falubaz Zielona Góra", "Ekstraliga", "1961");

            Players p12 = new Players("Patryk", "Dudek");
            Players p22 = new Players("Piotr", "Protasiewicz");
            Players p32 = new Players("Max", "Fricke");
            Players p42 = new Players("Matej", "Zagar");

            Clubs c3 = new Clubs("Stal Gorzów", "Ekstraliga", "1947");

            Players p13 = new Players("Bartosz", "Zmarzlik");
            Players p23 = new Players("Szymon", "Woźniak");
            Players p33 = new Players("Martin", "Vaculik");
            Players p43 = new Players("Anders", "Thomsen");

            Clubs c4 = new Clubs("Wybrzeże Gdańsk", "eWinner 1 Liga", "1945");

            Players p14 = new Players("Krystian", "Pieszczek");
            Players p24 = new Players("Jakub", "Jamróg");
            Players p34 = new Players("Michał", "Gruchalski");
            Players p44 = new Players("Viktor", "Kulakov");

            Clubs c5 = new Clubs("ROW Rybnik", "eWinner 1 Liga", "1932");

            Players p15 = new Players("Rune", "Holta");
            Players p25 = new Players("Kacper", "Gomólski");
            Players p35 = new Players("Michael", "Jepsen Jensen");
            Players p45 = new Players("Viktor", "Trofimov");




            c1.OutputInfo();
            Console.WriteLine();
            p1.OutputInfo();
            p2.OutputInfo();
            p3.OutputInfo();
            p4.OutputInfo();
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------");
            c2.OutputInfo();
            Console.WriteLine();
            p12.OutputInfo();
            p22.OutputInfo();
            p32.OutputInfo();
            p42.OutputInfo();
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------");
            c3.OutputInfo();
            Console.WriteLine();
            p13.OutputInfo();
            p23.OutputInfo();
            p33.OutputInfo();
            p43.OutputInfo();
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------");
            c4.OutputInfo();
            Console.WriteLine();
            p14.OutputInfo();
            p24.OutputInfo();
            p34.OutputInfo();
            p44.OutputInfo();
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------");
            c5.OutputInfo();
            Console.WriteLine();
            p15.OutputInfo();
            p25.OutputInfo();
            p35.OutputInfo();
            p45.OutputInfo();
            Console.WriteLine("-----------------------------------------------");

            Console.ReadKey();

            Matches m1 = new Matches(c1.Names, c2.Names);

            Console.WriteLine("First match:");
            m1.ResultOfTheMatch(49, 41);
            Console.WriteLine("Points of selected players:");
            p1.PointsPlayers(13);
            p3.PointsPlayers(9);
            p22.PointsPlayers(10);
            p42.PointsPlayers(7);

            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------");


            Matches m2 = new Matches(c1.Names, c3.Names);
            //Console.WriteLine("Introduce the result.");
            //Console.Write("First team: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Second team: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            Console.WriteLine("Second match:");
            m2.ResultOfTheMatch(40, 50);
            Console.WriteLine("Points of selected players:");
            p2.PointsPlayers(8);
            p4.PointsPlayers(9);
            p13.PointsPlayers(15);
            p23.PointsPlayers(11);

            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Third match:");

            Matches m3 = new Matches(c5.Names, c4.Names);


            m3.ResultOfTheMatch(52, 38);
            Console.WriteLine("Points of selected players:");
            p15.PointsPlayers(12);
            p35.PointsPlayers(5);
            p14.PointsPlayers(11);
            p44.PointsPlayers(8);

            Console.ReadKey();

        }
    }
}
