using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Interfaces
{
	/// <summary>
	/// Player Template With a User Id for Rainbow6
	/// </summary>
	public interface IPlayer
	{
		/// <summary>
		/// User Id of Player
		/// </summary>
		string User { get; }
		/// <summary>
		/// Retrieve User Avatar
		/// </summary>
		/// <returns>Url String of User Profile Image</returns>
		string GetAvatar ();
	}
}
