namespace ChunkPriorityCalculator.Model
{
	/// <summary>
	/// Price of the mineral in Enceladus's market.
	/// </summary>
	public class OreMarketPrice
	{
		/// <summary>
		/// The type of ore.
		/// </summary>
		public OreType OreType { get; set; }

		/// <summary>
		/// The price per 1 ton of mineral.
		/// </summary>
		public decimal Price { get; set; }
	}
}
