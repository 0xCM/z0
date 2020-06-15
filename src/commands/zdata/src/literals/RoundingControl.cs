//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;

	/// <summary>Rounding control</summary>
	public enum RoundingControl 
	{
		/// <summary>No rounding mode</summary>
		None = 0,
		
		/// <summary>Round to nearest (even)</summary>
		RoundToNearest = 1,
		
		/// <summary>Round down (toward -inf)</summary>
		RoundDown = 2,
		
		/// <summary>Round up (toward +inf)</summary>
		RoundUp = 3,
		
		/// <summary>Round toward zero (truncate)</summary>
		RoundTowardZero = 4,
	}
}