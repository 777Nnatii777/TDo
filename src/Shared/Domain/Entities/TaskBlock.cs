namespace Domain.Entities
{
	public class TaskBlock
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Stage { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? DueDate { get; set; }
		public bool IsCompleted { get; set; }
		public string Color { get; set; }
		public int Order { get; set; }
	}
}
