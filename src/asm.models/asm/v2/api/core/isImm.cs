//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
        
    using static Konst;
    using static Asm.OpKind;

    partial struct asm
    {
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSignedImm(OpKind src)
            => src == Immediate8to16  
            || src == Immediate8to32  
            || src == Immediate8to64  
            || src == Immediate32to64;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isDirectImm(OpKind src)
            => src == Immediate8
            || src == Immediate16
            || src == Immediate32
            || src == Immediate64;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSpecialImm(OpKind src)
            => src == Immediate8_2nd;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isImm(OpKind src)
            => isSignedImm(src) || isDirectImm(src) || isSpecialImm(src);            
    }
}