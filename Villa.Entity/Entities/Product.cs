using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
	public class Product
	{
		public string ImageURL { get; set; }
		public string Category { get; set; }
		public string Price { get; set; }
		public string Title { get; set; }
		public int BadroomCount { get; set; }
		public int BathroomCount { get; set; }
		public int Area { get; set; }
		public int Floor { get; set; }
		public int ParkingCount { get; set; }
	}
}
