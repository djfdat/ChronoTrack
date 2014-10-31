using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace ChronoTrack
{
	class Task
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name;
		public int CategoryId;
	}
}
