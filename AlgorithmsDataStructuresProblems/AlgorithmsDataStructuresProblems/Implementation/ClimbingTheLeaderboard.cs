using AlgorithmsDataStructuresProblems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresProblems.Implementation
{
    internal class ClimbingTheLeaderboard : IProblem
    {
        public void Solve()
        {
            Console.WriteLine($"Rezolvarea problemei {nameof(FormingMagicSquare)}");
            var ranked = new List<int> { 100, 100, 50,40,40,20,10};
            var playerScores = new List<int>() { 5, 25, 50, 129 };

            var list = climbingLeaderboard(ranked, playerScores);
            foreach( var score in list )
            {
                Console.Write($"{score} ");
            }
        }

        public static List<int> climbingLeaderboardNew (List<int> ranked, List<int> player)
        {
            var resultList = new List<int>();
            var rankScores = new List<int>();

            rankScores.Add(ranked[0]);
            for( int i = 1; i < ranked.Count; i++ )
            {
                var last = rankScores[rankScores.Count - 1];
                var curent = ranked[i];

                if(curent != last)
                    rankScores.Add(curent);
            }

            int totalLevelsToPlay = player.Count;
            int rankTemp = rankScores.Count + 1;
            int indexGame = 0;
            var currentRoundRank = rankTemp;

            while(totalLevelsToPlay > 0)
            {
                int nextPlayerScore = player[indexGame++];
                var indexRankScore = currentRoundRank - 2;

                while (indexRankScore > -1) 
                {
                    var nextHigherRankedPlayerScore = rankScores[indexRankScore--];

                    if(nextPlayerScore >= nextHigherRankedPlayerScore)
                    {
                        currentRoundRank--;
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }


                resultList.Add(currentRoundRank);
                totalLevelsToPlay--;
            }

            return resultList;
        }

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var listResult = new List<int>();
            var dic = new Dictionary<int, int>();
            foreach( var item in ranked )
            {
                if (!dic.ContainsKey(item))
                    dic[item] = 1;
                else
                    dic[item]++;
            }

            //var nbRankes = dic.Count;
            //var pozRank = nbRankes;
            var currentRoundRank = dic.Count + 1;

            foreach ( var playerScore in player )
            {
                //var chekced = false;

                var indexRankScore = currentRoundRank - 2;

                while (indexRankScore > -1 )
                {
                    var nextHigherRankedPlayerScore = dic.ElementAt(indexRankScore--).Key;

                    if (playerScore >= nextHigherRankedPlayerScore)
                    {
                        currentRoundRank--;
                        continue;
                    }
                    else
                        break;
                }

                listResult.Add(currentRoundRank);

                //for ( int i = nbRankes - 1; i >= 0; i--)
                //{
                //    var v1 = dic.ElementAt(i).Key;

                //    if (playerScore < dic.ElementAt(i).Key )
                //    {
                //        pozRank = i + 2;
                //        chekced = true;
                //        break;
                //    }
                //    else if (playerScore == v1)
                //    {
                //        pozRank = i + 1;
                //        chekced = true;
                //        break;
                //    }

                //}

                //if (chekced)
                //{
                //    listResult.Add(pozRank);
                //}
                //else
                //{
                //    listResult.Add(1);
                //}               

            }

            return new List<int>( listResult );
        }
    }
}
