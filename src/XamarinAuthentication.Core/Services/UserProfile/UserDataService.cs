using XamarinAuthentication.Core.Models;

namespace XamarinAuthentication.Core.Services.UserProfile
{
	public class UserDataService: IUserDataService
	{
		private User _user;

		public User GetUser()
		{
			if (this._user != null) {
				return this._user;
			}

			this._user = new User("Veronika", 26, "Brno");
			return this._user;
		}
	}
}