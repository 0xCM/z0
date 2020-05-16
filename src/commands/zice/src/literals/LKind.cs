//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Seed;
    using static Memories;

	public enum LKind : byte {
		None,
		/// <summary>.128, .256, .512</summary>
		L128,
		/// <summary>.L0, .L1</summary>
		L0,
		/// <summary>.LZ</summary>
		LZ,
	}
}