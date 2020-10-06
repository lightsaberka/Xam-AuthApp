﻿using System.Collections.Generic;
using XamarinAuthentication.Core.Models;

namespace XamarinAuthentication.Core.Services.DataService
{
	public class ExampleDataService: IExampleDataService
	{
		private User _user;
		private List<string> _cities;

		public User GetUser()
		{
			if (this._user != null) {
				return this._user;
			}

			this._user = new User("Veronika", "Brno", "girl", "email@email.cz");
			return this._user;
		}

		public List<string> GetCities()
		{
			if (this._cities != null) {
				return this._cities;
			}

			this._cities = new List<string> { "brno", "kosice", "wales", "standford", "stiavnica", "vlkolinec", "cicmany", "bojnice" };
			return this._cities;
		}
	}
}