using System.Collections.Generic;
using System;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myNumberHandler = new NumberHandler();
            var printer = new Printer();

            List<int> myNumbers = new List<int>() { 1, 10, 13, 45, 23, 245, 432, 123, 4523, 14564, 785, 8, 20, 32, 14, 18, 25 };

            List<int> myNumbers2 = new List<int>() { 2,3, 6,12,18,21,4,5 };
            List<int> myDivisors = new List<int>() { 2, 3};

            var oddNumbers = myNumberHandler.GetOddNumbers(myNumbers);
            var evenNumbers = myNumberHandler.GetEvenNumbers(myNumbers);
            var divisibleByAllNumbers = myNumberHandler.GetNumbersDivisibleByAllDivisors(myNumbers2, myDivisors);
            var divisibleByAtLeastOneNumbers = myNumberHandler.GetNumbersDivisibleByAtLeastOneDivisor(myNumbers2, myDivisors);
            var notDivisibleNumbers = myNumberHandler.GetNumbersNotDivisibleByAnyDivisor(myNumbers2, myDivisors);


            printer.PrintNumbers("Odd numbers",oddNumbers);
            printer.PrintNumbers("Even numbers", evenNumbers);
            printer.PrintNumbers("Numbers divisible by all divisors", divisibleByAllNumbers);
            printer.PrintNumbers("Numbers divisible by at least one divisor", divisibleByAtLeastOneNumbers);
            printer.PrintNumbers("Not divisible numbers", notDivisibleNumbers);


            var myChessPlayerParser = new ChessPlayersParser();

            var player1 = new ChessPlayer();
            player1.FirstName = "Giovanni";
            player1.Country = Country.Italy;
            player1.Birthdate = new System.DateTime(1990, 12, 5);
            player1.AgeInYears = 15;
            player1.EloRating = 15;

            var player2 = new ChessPlayer();
            player2.FirstName = "Vincenzo";
            player2.Country = Country.Italy;
            player2.AgeInYears = 45;
            player2.Birthdate = new System.DateTime(1982, 12, 5);
            player2.EloRating = 23;

            var player3 = new ChessPlayer();
            player3.FirstName = "Ivan";
            player3.AgeInYears = 22;
            player3.Country = Country.Russia;
             player3.Birthdate = new System.DateTime(1982, 12, 5);
            player3.EloRating = 40;
            myChessPlayerParser.chessPlayers.Add(player1);
            myChessPlayerParser.chessPlayers.Add(player2);
            myChessPlayerParser.chessPlayers.Add(player3);

            var playersResults = myChessPlayerParser.GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(14, Country.Italy);
            var playersResults2 = myChessPlayerParser.GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(15);
            var playersResults3 = myChessPlayerParser.GetChessPlayersOlderThanSpecifiedAge(16);

            Console.WriteLine("Players oldler than 14 from italy");
            foreach (var item in playersResults)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.WriteLine("Players with higher or equal rating");
            foreach (IGrouping<Country, ChessPlayer> item in playersResults2)
            {
                //Console.WriteLine(item.Key + " " + item.ElementAt(0).FirstName);
                for (int i = 0; i < item.Count(); i++)
                {
                    Console.WriteLine(item.Key + " " + item.ElementAt(i).FirstName);
                }
            }

            Console.WriteLine("Older players than 16");
            foreach (var item in playersResults3)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }

}
