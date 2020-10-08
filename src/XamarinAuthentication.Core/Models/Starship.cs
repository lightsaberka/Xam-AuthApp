namespace XamarinAuthentication.Core.Models
{
	public class Starship
	{
		public string Name { get; set; }

		/// <summary>
		/// Register number and type of starship.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Year when starship was first developed.
		/// </summary>
		public int Year { get; set; }

		/// <summary>
		/// Length of starship in metres.
		/// </summary>
		public string Length { get; set; }

		public string Photo { get; set; }

		public Starship(string name, string type, int year, string length, string photo)
		{
			this.Name = name;
			this.Type = type;
			this.Year = year;
			this.Length = length;
			this.Photo = photo;
		}
	}
}