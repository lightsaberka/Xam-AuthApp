using System.Collections.Generic;

namespace XamarinAuthentication.Core.Models
{
	public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Hometown { get; set; }

		public User(string name, int age, string hometown)
		{
			this.Name = name;
			this.Age = age;
			this.Hometown = hometown;
		}
	}
}