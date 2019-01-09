namespace Bede.Lottery.Core.Models
{
	public class Winner
	{
		public int Id { get; set; }
		public Employee WinningEmployee { get; set; }
		public Prize WinningPrize { get; set; }
		public string PrizeDraw { get; set; }
	}
}
