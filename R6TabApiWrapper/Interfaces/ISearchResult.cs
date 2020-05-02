using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Interfaces
{
	/// <summary>
	/// R6.Tab Api Response
	/// </summary>
	public interface ISearchResult
	{
		/// <summary>
		/// Http Status Code of Api Response
		/// </summary>
		int Status { get; }
	}
}
