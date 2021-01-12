//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Asm.IceOpKind;

    partial struct asm
    {
		/// <summary>
		/// Extracts an immediate operand from an instruction
		/// </summary>
		/// <param name="src">The source instruction</param>
		/// <param name="index">The operand index</param>
        [Op]
        public static ImmValue? immval(IceInstruction src, byte index)
        {
			return kind(src, index) switch
            {
			    Immediate8 => src.Immediate8,
			    Immediate8_2nd => src.Immediate8_2nd,
			    Immediate16 => src.Immediate16,
			    Immediate32 => src.Immediate32,
                Immediate64 => src.Immediate64,
			    Immediate8to16 => (ulong)src.Immediate8to16,
			    Immediate8to32 => (ulong)src.Immediate8to32,
			    Immediate8to64 => (ulong)src.Immediate8to64,
			    Immediate32to64 => (ulong)src.Immediate32to64,
			    _ => null
			};
		}
    }
}