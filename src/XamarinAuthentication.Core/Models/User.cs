﻿namespace XamarinAuthentication.Core.Models
{
	public class User
	{
		public string Name { get; set; }

		public string Hometown { get; set; }

		public string Email { get; set; }

		public string Photo { get; set; }

		public User(string name, string hometown, string photo, string email)
		{
			this.Name = name;
			this.Hometown = hometown;
			this.Photo = photo;
			this.Email = email;
		}
	}
}