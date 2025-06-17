namespace SlotsAnalysis
{
    /// <summary>
    /// Represents the Red, White & Blue slot machine.
    /// </summary>
    public class RedWhiteAndBlue(Random r) : ISlotMachine
    {
        private static readonly RWBSymbol[] _reel1 =
        {
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Red7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
        };

        private static readonly RWBSymbol[] _reel2 =
        {
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.White7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blue7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Red7,
            RWBSymbol.Red7,
            RWBSymbol.Red7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
        };

        private static readonly RWBSymbol[] _reel3 = {
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.White7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blue7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Red7,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.ThreeBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.TwoBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.OneBar,
            RWBSymbol.Blank,
            RWBSymbol.Blank,
        };

        private static RWBSymbol[][] _reels = { _reel1, _reel2, _reel3 };

        private Random _r = r;

        public string Name => "Red, White & Blue";

        public int Spin(int betAmount)
        {
            var symbols = new RWBSymbol[3];

            for (int i = 0; i < _reels.Length; i++)
            {
                symbols[i] = _reels[i][this._r.Next(_reels[i].Length)];
            }

            return betAmount / 3 * ScoreSymbols(symbols);
        }

        private int ScoreSymbols(RWBSymbol[] symbols)
        {
            if (symbols[0] == RWBSymbol.Red7 && symbols[1] == RWBSymbol.White7 && symbols[2] == RWBSymbol.Blue7) return 10000;
            if (symbols[0] == symbols[1] && symbols[0] == symbols[2])
            {
                switch (symbols[0])
                {
                    case RWBSymbol.Red7:
                        return 5000;
                    case RWBSymbol.White7:
                        return 600;
                    case RWBSymbol.Blue7:
                        return 450;
                    case RWBSymbol.ThreeBar:
                        return 120;
                    case RWBSymbol.TwoBar:
                        return 75;
                    case RWBSymbol.OneBar:
                        return 30;
                    case RWBSymbol.Blank:
                        return 3;
                }
            }

            if (IsSeven(symbols[0]) && IsSeven(symbols[1]) && IsSeven(symbols[2])) return 240;
            if (symbols[0] == RWBSymbol.OneBar && symbols[1] == RWBSymbol.TwoBar && symbols[2] == RWBSymbol.ThreeBar) return 150;
            if (IsRed(symbols[0]) && IsWhite(symbols[1]) && IsBlue(symbols[2])) return 60;
            if (IsBar(symbols[0]) && IsBar(symbols[1]) && IsBar(symbols[2])) return 15;
            if (IsRed(symbols[0]) && IsRed(symbols[1]) && IsRed(symbols[2])) return 6;
            if (IsWhite(symbols[0]) && IsWhite(symbols[1]) && IsWhite(symbols[2])) return 6;
            if (IsBlue(symbols[0]) && IsBlue(symbols[1]) && IsBlue(symbols[2])) return 6;

            return 0;
        }

        private static bool IsSeven(RWBSymbol symbol)
        {
            return symbol == RWBSymbol.Red7 || symbol == RWBSymbol.White7 || symbol == RWBSymbol.Blue7;
        }

        private static bool IsRed(RWBSymbol symbol)
        {
            return symbol == RWBSymbol.Red7 || symbol == RWBSymbol.OneBar;
        }

        private static bool IsWhite(RWBSymbol symbol)
        {
            return symbol == RWBSymbol.White7 || symbol == RWBSymbol.TwoBar;
        }

        private static bool IsBlue(RWBSymbol symbol)
        {
            return symbol == RWBSymbol.Blue7 || symbol == RWBSymbol.ThreeBar;
        }

        private static bool IsBar(RWBSymbol symbol)
        {
            return symbol == RWBSymbol.OneBar || symbol == RWBSymbol.TwoBar || symbol == RWBSymbol.ThreeBar;
        }
    }
}
