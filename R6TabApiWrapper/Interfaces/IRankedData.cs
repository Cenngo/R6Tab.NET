namespace R6Api.Interfaces
{
    /// <summary>
    /// Ranked Data Template that Contains Rank Info for Rainbow6
    /// </summary>
    public interface IRankedData
    {
        /// <summary>
        /// Rank of Player
        /// </summary>
        int Rank { get; }
        /// <summary>
        /// Retrieve Rank Banner
        /// </summary>
        /// <returns>Url String of Players Rank Banner</returns>
        string GetRankImg ( );
    }
}
