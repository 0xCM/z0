//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;
	using System.Linq;

	[Flags]
	public enum RflagsBits {
		None	= 0,
		OF		= 0x00000001,
		SF		= 0x00000002,
		ZF		= 0x00000004,
		AF		= 0x00000008,
		CF		= 0x00000010,
		PF		= 0x00000020,
		DF		= 0x00000040,
		IF		= 0x00000080,
		AC		= 0x00000100,
	}
}