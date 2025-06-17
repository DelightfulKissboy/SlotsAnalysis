namespace SlotsAnalysis
{
    /// <summary>
    /// Represents a slot machine.
    /// </summary>
    public interface ISlotMachine
    {
        string Name { get; }

        /// <summary>
        /// Spins the slot with a given bet amount.
        /// </summary>
        /// <param name="betAmount">Bet amount, represented in cents</param>
        /// <returns>The amount paid out by the machine</returns>
        int Spin(int betAmount);
    }
}
