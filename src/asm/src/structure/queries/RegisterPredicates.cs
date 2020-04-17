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

	partial class ModelQueries
    {
        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool IsRegister(this OpKind src)
            => src == OpKind.Register;  

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        public static Option<AsmRegisterInfo> RegisterInfo(this Instruction src, int index)
            => src.GetOpKind(index).IsRegister() ? new AsmRegisterInfo(src.GetOpRegister(index)) : none<AsmRegisterInfo>();
    }
}