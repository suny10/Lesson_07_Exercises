using System.Collections.Generic;
using System;

namespace Lesson_07_Exercises.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myNumberHandler = new NumberHandler();
            var printer = new Printer();

            List<int> myNumbers = new List<int>() { 1, 10, 13, 45, 23, 245, 432, 123, 4523, 14564, 785, 8, 20, 32, 14, 18, 25 };
            List<int> myDivisors = new List<int>() { 2, 3};

            var oddNumbers = myNumberHandler.GetOddNumbers(myNumbers);
            var evenNumbers = myNumberHandler.GetEvenNumbers(myNumbers);
            var divisibleByAllNumbers = myNumberHandler.GetNumbersDivisibleByAllDivisors(myNumbers, myDivisors);
            //var divisibleByAtLeastOneNumbers = myNumberHandler.GetNumbersDivisibleByAtLeastOneDivisor(myNumbers, myDivisors);
            //var notDivisibleNumbers = myNumberHandler.GetNumbersNotDivisibleByAnyDivisor(myNumbers, myDivisors);


            printer.PrintNumbers("Odd numbers",oddNumbers);
            printer.PrintNumbers("Even numbers", evenNumbers);
            printer.PrintNumbers("Numbers divisible by all divisors", divisibleByAllNumbers);
            //printer.PrintNumbers(divisibleByAtLeastOneNumbers);
            //printer.PrintNumbers(notDivisibleNumbers);


            var myChessPlayerParser = new ChessPlayersParser();
            var player1 = new ChessPlayer();
            player1.FirstName = "Giovanni";
            player1.Country = Country.Italy;
            player1.Birthdate = new System.DateTime(1990, 12, 5);
            player1.EloRating = 15;
            var player2 = new ChessPlayer();
            player2.FirstName = "Vincenzo";
            player2.Country = Country.Italy;
            player2.Birthdate = new System.DateTime(1982, 12, 5);
            player2.EloRating = 23;
            var player3 = new ChessPlayer();
            player3.FirstName = "Ivan";
            player3.Country = Country.Russia;
            player3.Birthdate = new System.DateTime(1982, 12, 5);
            player3.EloRating = 40;
            myChessPlayerParser.chessPlayers.Add(player1);
            myChessPlayerParser.chessPlayers.Add(player2);
            myChessPlayerParser.chessPlayers.Add(player3);

            //var playersResults = myChessPlayerParser.GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(14, Country.Italy);
            var playersResults = myChessPlayerParser.GetChessPlayersOlderThanSpecifiedAge(14);

            foreach (var item in playersResults)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }

}
