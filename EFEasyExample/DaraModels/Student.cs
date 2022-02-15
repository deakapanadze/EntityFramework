using System;
using System.Collections.Generic;
using System.Text;

namespace EFEasyExample.DaraModels
{
		public class Student
		{

			public int StudentId { get; set; }
			public string StudentName { get; set; }
			public  int	Age { get; set; }

			public List<Class> StudentClasses { get; set; }

		}
}
