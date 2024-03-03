namespace Villa.Entity.Entities
{
	public class Feature : BaseEntity
	{
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string ImageURL { get; set; }
		public string Square { get; set; }
		public string Contract { get; set; }
		public string Payment { get; set; }
		public bool HasSafety { get; set; }
	}
}