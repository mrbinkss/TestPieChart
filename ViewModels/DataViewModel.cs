using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPieChart.Models;

namespace TestPieChart.ViewModels
{
	public class DataViewModel
	{
		public ObservableCollection<DataModel> Products { get; set; }

		public DataViewModel() 
		{
			Products = new ObservableCollection<DataModel>
			{
				new DataModel() { Name = "ipad", Sales = 16},
				new DataModel() { Name = "iphone", Sales = 18},
				new DataModel() { Name = "Macbook", Sales = 13},
				new DataModel() { Name = "Mac", Sales = 15},
				new DataModel() { Name = "others", Sales = 36},
			};
		}
	}
}
