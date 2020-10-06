﻿using System.Threading.Tasks;

namespace XamarinAuthentication.Core.Services.Authentication
{
	public interface IAuthService
	{
		/// <summary>
		/// Authenticate user using his Biometric information or PIN/pattern.
		/// </summary>
		/// <returns></returns>
		Task<bool> Authenticate();
	}
}