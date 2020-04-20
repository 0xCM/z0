//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;    
    using static OpKind;

    public class AsmImm
    {
        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static int size(OpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return 8;
            else if(src == Immediate16 || src == Immediate8to16)
                return 16;
            else if(src == Immediate32 || src == Immediate8to32)
                return 32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return 64;
            else
                return 0;
        }

		/// <summary>
		/// Extracts an immediate operand from an instruction
		/// </summary>
		/// <param name="src">The source instruction</param>
		/// <param name="index">The operand index</param>
        public static ulong extract(Instruction src, int index) 
        {
			switch (AsmInstruction.kind(src,index)) {
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
				throw new ArgumentException($"Op{index} isn't an immediate operand", nameof(index));
			}
		}

        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool signed(OpKind src)
            => src == OpKind.Immediate8to16  
            || src == OpKind.Immediate8to32  
            || src == OpKind.Immediate8to64  
            || src == OpKind.Immediate32to64;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool direct(OpKind src)
            => src == OpKind.Immediate8
            || src == OpKind.Immediate16
            || src == OpKind.Immediate32
            || src == OpKind.Immediate64;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool special8(OpKind src)
            => src == OpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool any(OpKind src)
            => signed(src) || direct(src) || special8(src);

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmImmInfo> describe(Instruction src, int index)
        {
            var k =  AsmInstruction.kind(src,index);
            if(!any(k))
                return none<AsmImmInfo>();

            int sz = size(k);
            if(sz == 0)
                return none<AsmImmInfo>();

            var signed =  AsmImm.signed(k);
            var imm = extract(src,index);
            switch(sz)
            {
                case Pow2.T03:
                    return AsmImmInfo.Define(sz, imm);
                case Pow2.T04:
                    if(signed)
                        return AsmImmInfo.Define(sz, (long)imm);
                    else 
                        return AsmImmInfo.Define(sz, imm);
                case Pow2.T05:
                    if(signed)
                        return AsmImmInfo.Define(sz, (long)imm);
                    else 
                        return AsmImmInfo.Define(sz, imm);
                case Pow2.T06:
                    if(signed)
                        return AsmImmInfo.Define(sz, (long)imm);
                    else 
                        return AsmImmInfo.Define(sz, imm);
                default:
                    return none<AsmImmInfo>();
            }
        }
    }
}