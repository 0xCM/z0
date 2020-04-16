//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

	partial class ModelQueries
    {
		/// <summary>
		/// Extracts an immediate operand from an instruction
		/// </summary>
		/// <param name="src">The source instruction</param>
		/// <param name="operand">The operand index</param>
        public static ulong GetImmediate(this Instruction src, int operand) {
			switch (src.GetOpKind(operand)) {
			case OpKind.Immediate8:			return src.Immediate8;
			case OpKind.Immediate8_2nd:		return src.Immediate8_2nd;
			case OpKind.Immediate16:		return src.Immediate16;
			case OpKind.Immediate32:		return src.Immediate32;
			case OpKind.Immediate64:		return src.Immediate64;
			case OpKind.Immediate8to16:		return (ulong)src.Immediate8to16;
			case OpKind.Immediate8to32:		return (ulong)src.Immediate8to32;
			case OpKind.Immediate8to64:		return (ulong)src.Immediate8to64;
			case OpKind.Immediate32to64:	return (ulong)src.Immediate32to64;
			default:
				throw new ArgumentException($"Op{operand} isn't an immediate operand", nameof(operand));
			}
		}
    }
}