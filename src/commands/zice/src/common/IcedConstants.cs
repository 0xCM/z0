//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
	
	static class IcedConstants 
    {
		internal const int MaxOpCount = 5;
		internal const int MaxInstructionLength = 15;
		internal const int RegisterBits = 8;
		internal const int NumberOfCodeValues = 4212;
		internal const int NumberOfRegisters = 241;
		internal const int NumberOfMemorySizes = 136;
		internal const int NumberOfEncodingKinds = 5;
		internal const int NumberOfOpKinds = 26;
		internal const int NumberOfCodeSizes = 4;
		internal const int NumberOfRoundingControlValues = 5;
		internal const Register VMM_first = Register.ZMM0;
		internal const Register VMM_last = Register.ZMM31;
		internal const int VMM_count = 32;
		internal const Register XMM_last = Register.XMM31;
		internal const Register YMM_last = Register.YMM31;
		internal const Register ZMM_last = Register.ZMM31;
		internal const int MaxCpuidFeatureInternalValues = 152;
		internal const MemorySize FirstBroadcastMemorySize = MemorySize.Broadcast64_UInt32;
	}

}