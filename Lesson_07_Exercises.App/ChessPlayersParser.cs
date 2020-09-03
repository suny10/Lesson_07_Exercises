using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_Exercises.App
{
    public class ChessPlayersParser : IChessPlayersParser
    {
        public List<ChessPlayer> chessPlayers;

        public ChessPlayersParser()
        {
            chessPlayers = new List<ChessPlayer>();
        }
        public IEnumerable<ChessPlayer> GetChessPlayersInEloRatingRange(int minEloRating, int maxEloRating)
        {
            var results = chessPlayers.Where(n => n.EloRating >= minEloRating && n.EloRating <= maxEloRating);
            return results;
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAge(int ageInYears)
        {
            var results = chessPlayers.Where(n => n.AgeInYears > ageInYears);
            return results;
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(int ageInYears, Country country)
        {
            var results = chessPlayers.Where(n => n.AgeInYears > ageInYears).Where(n => n.Country == country);
            return results;
        }

        public IEnumerable<IGrouping<Country, ChessPlayer>> GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(int minEloRating)
        {
            IEnumerable<IGrouping<Country, ChessPlayer>> results = chessPlayers.Where(n => n.EloRating >= minEloRating).GroupBy(p => p.Country);
            return results;
        }
    }
}
