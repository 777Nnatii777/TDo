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
				new TaskBlock { Id = 1, Name = "Task 1", Description = "Description 1", Status = "To Do"},
				new TaskBlock { Id = 2, Name = "Task 2", Description = "Description 2", Status = "In Progress"},
				new TaskBlock { Id = 3, Name = "Task 3", Description = "Description 3", Status = "Done"}
			};

		}
	}

}


