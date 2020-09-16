//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential)]
    public struct IceInstructionData
    {
		// Next RIP is only needed by RIP relative memory operands. Without this field the user would have
		// to pass this value to the formatter and encoder methods.
		internal readonly ulong NextRip;

		internal readonly uint CodeFlagValue;// CodeFlags

		internal readonly uint OpKindFlagValue;// OpKindFlags

        // If it's a 64-bit immediate/offset/target, the high 32 bits is in memDispl
		internal readonly uint Imm;

		// This is the high 32 bits if it's a 64-bit immediate/offset/target
		internal readonly uint MemDispl;

		internal readonly ushort MemFlagValue;// MemoryFlags

        internal readonly byte MemBaseReg;// Register

        internal readonly byte MemIndexReg;// Register

		// If a Register will need 9 bits in the future, it's probably best to turn this into a
		// uint (and move it below the other uint fields above). The remaining 4 bits of 'reg3'
		// can be stored in some other field (it's rarely used)
		internal readonly byte Reg0;

        internal readonly byte Reg1;

        internal readonly byte Reg2;

        internal readonly byte Reg3;
    }
}