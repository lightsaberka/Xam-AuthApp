using System.Collections.Generic;
using XamarinAuthentication.Core.Models;

namespace XamarinAuthentication.Core.Services.DataService
{
	public class ExampleDataService: IExampleDataService
	{
		private User _user;

		private List<string> _cities;

		private List<Starship> _starships;

		private string _loremIpsum = "These are the voyages of the Starship Enterprise.\n\nIts continuing mission, " +
		                             "to explore strange new worlds, to seek out new life and new civilizations, " +
		                             "to boldly go where no one has gone before. We need to neutralize the homing signal. " +
		                             "Each unit has total environmental control, gravity, temperature, atmosphere, light, " +
		                             "in a protective field. Sensors show energy readings in your area. " +
		                             "We had a forced chamber explosion in the resonator coil. Field strength has increased by 3,000 percent. " +
		                             "\n\nResistance is futile.";

		public User GetUser()
		{
			if (this._user != null) {
				return this._user;
			}

			this._user = new User("Veronika", "Brno", "girl")
			{
				GitHubUrl = "https://github.com/lightsaberka",
				SteamUrl = "https://store.steampowered.com/app/743360/Haste_Heist/",
				Email = "email@email.cz"
			};

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

		public string GetLoremIpsum()
		{
			return this._loremIpsum;
		}

		public List<Starship> GetStarships()
		{
			if (this._starships != null) {
				return this._starships;
			}
			var enterprise = new Starship("USS Enterprise", "NCC-1701 (Shuttlecraft)", 2245, "288.646 m", "enterprise");
			var sulaco = new Starship("USS Sulaco", "8 UD-4L (Utility dropship)", 2122, "385 m", "sulaco");

			this._starships = new List<Starship> {enterprise, sulaco};
			return this._starships;
		}
	}
}