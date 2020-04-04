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
		string User { get; }
		string GetAvatar ();
	}
}
