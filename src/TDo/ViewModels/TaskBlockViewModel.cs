using Domain.Entities;
using System.Collections.ObjectModel;

namespace TDo.ViewModels
{
	public class TaskBlockViewModel
	{
		public ObservableCollection<TaskBlock> Tasks { get; set; }

		public TaskBlockViewModel()
		{
			Tasks = new ObservableCollection<TaskBlock>
			{
				new TaskBlock { Id = 1, Title = "Task 1", Description = "Description 1", Stage = "To Do", Color = "#FFB6C1" },
				new TaskBlock { Id = 2, Title = "Task 2", Description = "Description 2", Stage = "In Progress", Color = "#ADD8E6" },
				new TaskBlock { Id = 3, Title = "Task 3", Description = "Description 3", Stage = "Done", Color = "#90EE90" }
			};
		}
	}

}


