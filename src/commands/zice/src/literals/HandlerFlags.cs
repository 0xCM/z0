//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	[Flags]
	public enum HandlerFlags : uint 
    {
		None = 0x00000000,
		Xacquire = 0x00000001,
		Xrelease = 0x00000002,
		XacquireXreleaseNoLock = 0x00000004,
		Lock = 0x00000008,
	}

}