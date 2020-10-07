using System.Collections.Generic;
using XamarinAuthentication.Core.Models;

namespace XamarinAuthentication.Core.Services.DataService
{
	public interface IExampleDataService
	{
		/// <summary>
		/// Generates and returns sample user.
		/// </summary>
		/// <returns>Sample user</returns>
		User GetUser();

		/// <summary>
		/// Generates and returns sample cities.
		/// </summary>
		/// <returns>Sample cities</returns>
		List<string> GetCities();

		/// <summary>
		/// Returns sample lorem ipsum text.
		/// </summary>
		/// <returns>Sample lorem ipsum text</returns>
		string GetLoremIpsum();
	}
}