namespace ChunkPriorityCalculator.Model
{
	public class SaveData
	{
		public string Description { get; set; } = string.Empty;
		public IEnumerable<OreMarketPrice>? MarketPrices { get; set; }
		public OreChunk? Chunk1 { get; set; }
		public OreChunk? Chunk2 { get; set; }
		public Dictionary<string, string>? RuleData { get; set; }
	}
}
