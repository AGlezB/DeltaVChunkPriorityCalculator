namespace ChunkPriorityCalculator.Model
{
	/// <summary>
	/// One roid chunk.
	/// </summary>
	public class OreChunk
	{
		/// <summary>
		/// The type of ore in the chunk.
		/// </summary>
		public OreType? OreType { get; set; }

		/// <summary>
		/// The ore content of the chunk in kilograms.
		/// </summary>
		public int OreWeightKg { get; set; }

		/// <summary>
		/// The water content of the chunk in kilograms.
		/// </summary>
		public int WaterWeightKg { get; set; }

		/// <summary>
		/// The total weight of the chunk in kilograms.
		/// </summary>
		public int TotalWeightKg => OreWeightKg + WaterWeightKg;

		/// <summary>
		/// The movement speed of the chunk relative to the ship in meters per second.
		/// <para><c> &gt;0 </c> the chunk is moving away from the ship.</para>
		/// <para><c> 0 </c> the chunk is static relative to the ship.</para>
		/// <para><c> &lt;0 </c> the chunk is moving towards the ship.</para>
		/// </summary>
		public decimal RelativeSpeed { get; set; }
	}
}
