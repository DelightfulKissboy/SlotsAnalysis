namespace SlotsAnalysis
{
    /// <summary>
    /// Represents the Double Diamond Deluxe slot machine. Note: only based off pay table.
    /// </summary>
    /// <param name="r">Random number generator</param>
    public class DoubleDiamondDeluxe(Random r) : ISlotMachine
    {
        private Random _r = r;

        private static Tuple<int, double>[] _payTable = {
            new(0,  0.85714592),
            new(6,  0.05079733),
            new(15,  0.06524884),
            new(30, 0.01928477),
            new(60, 0.00404557),
            new(75, 0.00090021),
            new(120,  0.00073410),
            new(150, 0.00096986),
            new(240, 0.00029471),
            new(300, 0.00027864),
            new(480, 0.00021433),
            new(960, 0.00006430),
            new(2500, 0.00002143)
        };

        public string Name => "Double Diamond Deluxe";

        public int Spin(int betAmount)
        {
            var spin = this._r.NextDouble();

            var payTablePos = 1;
            var weight = _payTable[0].Item2;
            var payout = _payTable[0].Item1;
            while (spin >= weight)
            {
                weight += _payTable[payTablePos].Item2;
                payout = _payTable[payTablePos].Item1;
                payTablePos++;
            }

            return betAmount / 3 * payout;
        }
    }
}
