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

	public enum MandatoryPrefixByte : uint {
		None,
		P66,
		PF3,
		PF2,
	}

}