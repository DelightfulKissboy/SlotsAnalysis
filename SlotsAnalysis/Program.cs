namespace SlotsAnalysis
{
    internal class Program
    {
        public static int NumTrials = 100000;
        public static int StartingMoney = 7500;
        public static int BetAmount = 75;

        static void Main(string[] args)
        {
            var r = new Random();
            var redWhiteAndBlue = new RedWhiteAndBlue(r);
            var luckyLarrysLobstermania = new LuckyLarrysLobstermania(r);
            var doubleDiamondDeluxe = new DoubleDiamondDeluxe(r);
            var slots = new ISlotMachine[] { redWhiteAndBlue, luckyLarrysLobstermania, doubleDiamondDeluxe };

            string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SlotsShowdown2.csv");
            using (StreamWriter outputFile = new StreamWriter(dataPath))
            {
                for (int i = 0; i < NumTrials; i++)
                {
                    var outcomes = new List<int>();
                    var spinCounts = new List<int>();
                    foreach (var slot in slots)
                    {
                        // Fixed bet amount
                        var bankroll = StartingMoney;
                        var numSpins = 0;
                        for (int j = 0; j < StartingMoney / BetAmount; j++)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Fixed bet amount, re-spin ties
                        bankroll = StartingMoney;
                        numSpins = 0;
                        for (int j = 0; j < StartingMoney / BetAmount; j++)
                        {
                            var tied = false;
                            do
                            {
                                bankroll -= BetAmount;
                                var result = slot.Spin(BetAmount);
                                bankroll += result;
                                numSpins++;
                                tied = result == BetAmount;
                            } while (tied);
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until any gain
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll <= StartingMoney)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 25% gain.
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 1.25)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 100% gain
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 2)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 400% gain
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 5)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 900% gain
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 10)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until any gain with fixed limit
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll <= StartingMoney && numSpins < StartingMoney / BetAmount)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 25% gain with fixed limit
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 1.25 && numSpins < StartingMoney / BetAmount)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 100% gain with fixed limit
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 2 && numSpins < StartingMoney / BetAmount)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 400% gain with fixed limit
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 5 && numSpins < StartingMoney / BetAmount)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);

                        // Keep betting until 900% gain with fixed limit
                        bankroll = StartingMoney;
                        numSpins = 0;
                        while (bankroll >= BetAmount && bankroll < StartingMoney * 10 && numSpins < StartingMoney / BetAmount)
                        {
                            bankroll -= BetAmount;
                            bankroll += slot.Spin(BetAmount);
                            numSpins++;
                        }

                        outcomes.Add(bankroll);
                        spinCounts.Add(numSpins);
                    }

                    foreach (var outcome in outcomes)
                    {
                        outputFile.Write($"${(double)outcome/100},");
                    }

                    foreach(var spinCount in spinCounts)
                    {
                        outputFile.Write($"{spinCount},");
                    }

                    outputFile.WriteLine();
                }
            }
        }
    }
}
