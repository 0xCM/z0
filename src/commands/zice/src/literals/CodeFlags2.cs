//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

	/// <summary>
	/// [12:0]	= <c>Code</c> enum
	/// [15:13]	= <c>RoundingControl</c> enum
	/// [18:16]	= Opmask register or 0 if none
	/// [22:19]	= Instruction length
	/// [24:23]	= Not used
	/// [25]	= Suppress all exceptions
	/// [26]	= Zeroing masking
	/// [27]	= xacquire prefix
	/// [28]	= xrelease prefix
	/// [29]	= repe prefix
	/// [30]	= repne prefix
	/// [31]	= lock prefix
	/// </summary>
	[Flags, NumericBase(16)]
	public enum CodeFlags2 : uint 
	{
		CodeBits				= 13,

		CodeMask				= (1 << (int)CodeBits) - 1,

		RoundingControlMask		= 7,

		RoundingControlShift	= 13,

		OpMaskMask				= 7,

		OpMaskShift				= 16,

		InstrLengthMask			= 0xF,

		InstrLengthShift		= 19,
		
		// Unused bits here
		SuppressAllExceptions	= 0x02000000,
		
		ZeroingMasking			= 0x04000000,
		
		XacquirePrefix			= 0x08000000,
		
		XreleasePrefix			= 0x10000000,
		
		RepePrefix				= 0x20000000,
		
		RepnePrefix				= 0x40000000,
		
		LockPrefix				= 0x80000000,

		// Bits ignored by Equals()
		EqualsIgnoreMask		= InstrLengthMask << (int)InstrLengthShift,
	}
}