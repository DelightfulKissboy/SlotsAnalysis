namespace SlotsAnalysis
{
    /// <summary>
    /// Represents the Lucky Larry's Lobstermania slot machine, 85% RTP.
    /// </summary>
    public class LuckyLarrysLobstermania(Random r) :ISlotMachine
    {
        /// <summary>
        /// Represents the number of symbols displayed per reel.
        /// </summary>
        private const int SymbolsPerReel = 3;

        /// <summary>
        /// Represents the reel strip of reel 1.
        /// </summary>
        private static readonly LLLSymbol[] _reel1 = {
            LLLSymbol.Tuna,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.LightHouse,
            LLLSymbol.Scatter,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Bonus,
            LLLSymbol.Logo,
            LLLSymbol.Scatter,
            LLLSymbol.Buoy,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Buoy,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Logo,
            LLLSymbol.LightHouse,
            LLLSymbol.Clam,
            LLLSymbol.Wild,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Wild,
            LLLSymbol.Bonus,
            LLLSymbol.Clam,
            LLLSymbol.Boat,
            LLLSymbol.StarFish,
            LLLSymbol.Tuna,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Tuna,
            LLLSymbol.Logo,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Boat,
            LLLSymbol.LightHouse,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Boat,
            LLLSymbol.Tuna,
            LLLSymbol.Buoy,
            LLLSymbol.SeaGull,
            LLLSymbol.Logo,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.Boat,
            LLLSymbol.SeaGull,
        };

        /// <summary>
        /// Represents the reel strip of reel 2.
        /// </summary>
        private static readonly LLLSymbol[] _reel2 =
        {
            LLLSymbol.Clam,
            LLLSymbol.Buoy,
            LLLSymbol.LightHouse,
            LLLSymbol.Clam,
            LLLSymbol.Buoy,
            LLLSymbol.LightHouse,
            LLLSymbol.Bonus,
            LLLSymbol.SeaGull,
            LLLSymbol.Clam,
            LLLSymbol.Boat,
            LLLSymbol.SeaGull,
            LLLSymbol.Tuna,
            LLLSymbol.Boat,
            LLLSymbol.Bonus,
            LLLSymbol.StarFish,
            LLLSymbol.SeaGull,
            LLLSymbol.Wild,
            LLLSymbol.Bonus,
            LLLSymbol.SeaGull,
            LLLSymbol.LightHouse,
            LLLSymbol.Logo,
            LLLSymbol.Wild,
            LLLSymbol.Buoy,
            LLLSymbol.Clam,
            LLLSymbol.Bonus,
            LLLSymbol.SeaGull,
            LLLSymbol.Clam,
            LLLSymbol.Scatter,
            LLLSymbol.Logo,
            LLLSymbol.Tuna,
            LLLSymbol.SeaGull,
            LLLSymbol.Scatter,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.Boat,
            LLLSymbol.Logo,
            LLLSymbol.SeaGull,
            LLLSymbol.Clam,
            LLLSymbol.Bonus,
            LLLSymbol.StarFish,
            LLLSymbol.SeaGull,
            LLLSymbol.Buoy,
            LLLSymbol.LightHouse,
            LLLSymbol.Clam,
            LLLSymbol.Tuna,
            LLLSymbol.SeaGull,
        };

        /// <summary>
        /// Represents the reel strip of reel 3.
        /// </summary>
        private static readonly LLLSymbol[] _reel3 = {
            LLLSymbol.Boat,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.Bonus,
            LLLSymbol.LightHouse,
            LLLSymbol.Boat,
            LLLSymbol.Logo,
            LLLSymbol.StarFish,
            LLLSymbol.Bonus,
            LLLSymbol.LightHouse,
            LLLSymbol.StarFish,
            LLLSymbol.Bonus,
            LLLSymbol.Tuna,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Wild,
            LLLSymbol.Bonus,
            LLLSymbol.LightHouse,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Tuna,
            LLLSymbol.Clam,
            LLLSymbol.Boat,
            LLLSymbol.Tuna,
            LLLSymbol.StarFish,
            LLLSymbol.Bonus,
            LLLSymbol.Tuna,
            LLLSymbol.LightHouse,
            LLLSymbol.StarFish,
            LLLSymbol.Scatter,
            LLLSymbol.LightHouse,
            LLLSymbol.Logo,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Scatter,
            LLLSymbol.Buoy,
            LLLSymbol.Tuna,
            LLLSymbol.Logo,
            LLLSymbol.Bonus,
            LLLSymbol.StarFish,
            LLLSymbol.LightHouse,
            LLLSymbol.SeaGull,
            LLLSymbol.Buoy,
            LLLSymbol.Boat,
            LLLSymbol.Tuna,
            LLLSymbol.Buoy,
        };

        /// <summary>
        /// Represents the reel strip of reel 4.
        /// </summary>
        private static readonly LLLSymbol[] _reel4 = {
            LLLSymbol.SeaGull,
            LLLSymbol.Tuna,
            LLLSymbol.Buoy,
            LLLSymbol.SeaGull,
            LLLSymbol.Scatter,
            LLLSymbol.Buoy,
            LLLSymbol.StarFish,
            LLLSymbol.SeaGull,
            LLLSymbol.Tuna,
            LLLSymbol.Wild,
            LLLSymbol.Buoy,
            LLLSymbol.Tuna,
            LLLSymbol.StarFish,
            LLLSymbol.Logo,
            LLLSymbol.SeaGull,
            LLLSymbol.Tuna,
            LLLSymbol.Wild,
            LLLSymbol.Logo,
            LLLSymbol.LightHouse,
            LLLSymbol.Buoy,
            LLLSymbol.SeaGull,
            LLLSymbol.Boat,
            LLLSymbol.Clam,
            LLLSymbol.StarFish,
            LLLSymbol.LightHouse,
            LLLSymbol.SeaGull,
            LLLSymbol.Boat,
            LLLSymbol.Clam,
            LLLSymbol.Buoy,
            LLLSymbol.SeaGull,
            LLLSymbol.Boat,
            LLLSymbol.LightHouse,
            LLLSymbol.StarFish,
            LLLSymbol.Tuna,
            LLLSymbol.SeaGull,
            LLLSymbol.Buoy,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.Buoy,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.Logo,
            LLLSymbol.Wild,
            LLLSymbol.Buoy,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Scatter,
            LLLSymbol.Tuna,
            LLLSymbol.Wild,
        };

        /// <summary>
        /// Represents the reel strip of reel 5.
        /// </summary>
        private static readonly LLLSymbol[] _reel5 =
        {
            LLLSymbol.Clam,
            LLLSymbol.Wild,
            LLLSymbol.Boat,
            LLLSymbol.Logo,
            LLLSymbol.Buoy,
            LLLSymbol.StarFish,
            LLLSymbol.LightHouse,
            LLLSymbol.Tuna,
            LLLSymbol.StarFish,
            LLLSymbol.LightHouse,
            LLLSymbol.SeaGull,
            LLLSymbol.Wild,
            LLLSymbol.Tuna,
            LLLSymbol.Buoy,
            LLLSymbol.Boat,
            LLLSymbol.Clam,
            LLLSymbol.Tuna,
            LLLSymbol.Buoy,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.Scatter,
            LLLSymbol.Buoy,
            LLLSymbol.StarFish,
            LLLSymbol.Tuna,
            LLLSymbol.Clam,
            LLLSymbol.Buoy,
            LLLSymbol.Boat,
            LLLSymbol.LightHouse,
            LLLSymbol.Tuna,
            LLLSymbol.Logo,
            LLLSymbol.LightHouse,
            LLLSymbol.SeaGull,
            LLLSymbol.Clam,
            LLLSymbol.Logo,
            LLLSymbol.StarFish,
            LLLSymbol.Boat,
            LLLSymbol.LightHouse,
            LLLSymbol.Tuna,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.LightHouse,
            LLLSymbol.Clam,
            LLLSymbol.Logo,
            LLLSymbol.SeaGull,
            LLLSymbol.StarFish,
            LLLSymbol.Clam,
            LLLSymbol.SeaGull,
            LLLSymbol.LightHouse,
            LLLSymbol.Scatter,
            LLLSymbol.StarFish,
        };

        /// <summary>
        /// Array of all reels.
        /// </summary>
        private static readonly LLLSymbol[][] _reels = { _reel1, _reel2, _reel3, _reel4, _reel5 };

        /// <summary>
        /// Maps symbols to their line payouts. Index 0 of the prize array represents a streak of 2.
        /// </summary>
        private static readonly Dictionary<LLLSymbol, int[]> _payTable = new Dictionary<LLLSymbol, int[]>() {
            { LLLSymbol.Wild, new int[]{ 5, 100, 500, 10000 } },
            { LLLSymbol.Logo, new int[]{ 2, 40, 200, 1000 } },
            { LLLSymbol.Buoy, new int[]{ 0, 25, 100, 500 } },
            { LLLSymbol.Boat, new int[]{ 0, 25, 100, 500 } },
            { LLLSymbol.LightHouse, new int[]{ 0, 10, 50, 500 } },
            { LLLSymbol.Tuna, new int[]{ 0, 10, 50, 250 } },
            { LLLSymbol.Clam, new int[]{ 0, 5, 30, 200 } },
            { LLLSymbol.SeaGull, new int[]{ 0, 5, 30, 200 } },
            { LLLSymbol.StarFish, new int[]{ 0, 5, 30, 150 } },
        };

        /// <summary>
        /// Represents the total weight for lobster win amounts in the bonus game.
        /// </summary>
        private const int _totalLobsterWeight = 322;

        /// <summary>
        /// Represents the probability weights for each lobster win amount in the bonus game.
        /// </summary>
        private static readonly int[,] _lobsterWinWeights =
        {
            { 5, 5 },
            { 6, 5 },
            { 7, 5 },
            { 8, 5 },
            { 10, 20 },
            { 12, 10 },
            { 15, 10 },
            { 20, 20 },
            { 22, 20 },
            { 25, 20 },
            { 27, 20 },
            { 30, 19 },
            { 35, 22 },
            { 45, 24 },
            { 50, 19 },
            { 55, 15 },
            { 60, 15 },
            { 65, 15 },
            { 70, 15 },
            { 75, 15 },
            { 100, 10 },
            { 150, 8 },
            { 250, 5 }
        };

        /// <summary>
        /// The random number generator used to generate spins.
        /// </summary>
        private readonly Random _r = r;

        public string Name => "Lucky Larry's Lobstermania";

        /// <summary>
        /// Spins the slot with a given bet amount.
        /// </summary>
        /// <param name="betAmount">Bet amount, represented in cents</param>
        /// <returns>The amount paid out by the machine</returns>
        public int Spin(int betAmount)
        {
            var symbols = this.GetSpinSymbols();
            var multiplier = this.ScoreFirstPayLine(symbols);
            multiplier += this.ScoreScatterPay(symbols);
            multiplier += this.ScoreBonus(symbols);

            return betAmount * multiplier;
        }

        /// <summary>
        /// Gets the symbols for a given spin.
        /// </summary>
        /// <returns>The symbols generated by the spin.</returns>
        private LLLSymbol[,] GetSpinSymbols()
        {
            var result = new LLLSymbol[_reels.Length, SymbolsPerReel];
            for (int i = 0; i < _reels.Length; i++)
            {
                var reel = _reels[i];
                var pos = this._r.Next(reel.Length);
                var resultPos = 0;
                while (resultPos < SymbolsPerReel)
                {
                    result[i, resultPos] = reel[pos];
                    resultPos++;

                    // Wrap back to begninning of reel if necessary.
                    pos = pos == reel.Length - 1 ? 0 : pos + 1;
                }
            }

            return result;
        }

        /// <summary>
        /// Scores the first (middle) pay line.
        /// </summary>
        /// <param name="symbols">The set of symbols generated by the spin</param>
        /// <returns>The score, as a multiplier of the bet amount</returns>
        private int ScoreFirstPayLine(LLLSymbol[,] symbols)
        {
            var scoringSymbol = symbols[0, 1];
            var streak = 1;
            for (int i = 1; i < _reels.Length; i++)
            {
                var symbol = symbols[i, 1];
                if (symbol != scoringSymbol)
                {
                    if (scoringSymbol == LLLSymbol.Wild)
                    {
                        scoringSymbol = symbol;
                    } else if (symbol != LLLSymbol.Wild)
                    {
                        break;
                    }
                }

                streak++;
            }

            if (streak == 1 || !_payTable.ContainsKey(scoringSymbol)) return 0;

            return _payTable[scoringSymbol][streak - 2];
        }

        /// <summary>
        /// Scores the scatter pay symbols.
        /// </summary>
        /// <param name="symbols">The set of symbols generated by the spin</param>
        /// <returns>The score, as a multiplier of the bet amount.</returns>
        private int ScoreScatterPay(LLLSymbol[,] symbols)
        {
            var scatterCount = 0;
            foreach (var symbol in symbols)
            {
                if (symbol == LLLSymbol.Scatter) scatterCount++;
            }

            switch (scatterCount)
            {
                case 5:
                    return 200;
                case 4:
                    return 25;
                case 3:
                    return 5;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Checks if the spin is elligble for the bonus round and scores it if so.
        /// </summary>
        /// <param name="symbols">The symbols spun</param>
        /// <returns>The score, as a multiplier of the bet amount.</returns>
        private int ScoreBonus(LLLSymbol[,] symbols)
        {
            if (!(symbols[0, 1] == LLLSymbol.Bonus && symbols[1, 1] == LLLSymbol.Bonus && symbols[2, 1] == LLLSymbol.Bonus)) return 0;

            var result = 0;
            var numTraps = this._r.Next(3) + 2;
            for (int i = 0; i < numTraps; i++)
            {
                var numLobsters = this._r.Next(2) + 2;
                for (int j = 0; j < numLobsters; j++)
                {
                    var lobsterWeight = this._r.Next(_totalLobsterWeight);
                    var weightPos = 1;
                    var curWeight = _lobsterWinWeights[0, 1];
                    var curWin = _lobsterWinWeights[0, 0];
                    while (curWeight <= lobsterWeight)
                    {
                        curWeight += _lobsterWinWeights[weightPos, 1];
                        curWin = _lobsterWinWeights[weightPos, 0];
                        weightPos++;
                    }

                    result += curWin;
                }
            }

            return result;
        }
    }
}
