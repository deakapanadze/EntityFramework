using EFEasyExample.DaraModels;
using EFEasyExample.Enums;
using System.Linq;
using System;
using System.Collections.Generic;

namespace EFEasyExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using Context myContext = new Context();
			var myClasses = myContext
				.Classes
				.FirstOrDefault(c => c.MaxClassSize > 0);

			myClasses.ClassName = "changed name!";

			//myContext.Students.Add(new Student()
			//{
			//	StudentName = "dea kapnadze",
			//	StudentClasses = new List<Class>()
			//	{ 
			//		new Class() 
			//		{ 
			//			ClassLanguage = Language.French,
			//			ClassName = "myfirstclass",
			//			MaxClassSize = 12
			//		},
			//		new Class()
			//		{
			//			ClassLanguage = Language.English,
			//			ClassName = "mysecondclass",
			//			MaxClassSize = 25
			//		}
			//	}
			//}
			//);
			//myContext.SaveChanges();
			
		}
	}
}
