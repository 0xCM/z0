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
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool IsSignExtendedImmediate(this OpKind src)
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
        public static bool IsDirectImmediate(this OpKind src)
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
        public static bool IsSpecialImmediate8(this OpKind src)
            => src == OpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool IsImmediate(this OpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();
    }
}