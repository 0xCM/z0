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

    [ApiHost]
    public readonly struct AsmOperandTest
    {
        [MethodImpl(Inline), Op]
        public static bool call(Instruction src)
            => src.Mnemonic == Mnemonic.Call;
        
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public bool branchNear(OpKind src)        
            => src == OpKind.NearBranch16
            || src == OpKind.NearBranch32
            || src == OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public bool branchFar(OpKind src)        
            => src == OpKind.FarBranch16
            || src == OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public bool branch(OpKind src)
            => branchNear(src) || branchFar(src);

        [MethodImpl(Inline), Op]
        public static bool immsigned(OpKind src)
            => src == Immediate8to16  
            || src == Immediate8to32  
            || src == Immediate8to64  
            || src == Immediate32to64;

        [MethodImpl(Inline), Op]
        public static bool immdirect(OpKind src)
            => src == Immediate8
            || src == Immediate16
            || src == Immediate32
            || src == Immediate64;

        [MethodImpl(Inline), Op]
        public static bool immspecial(OpKind src)
            => src == Immediate8_2nd;

        [MethodImpl(Inline), Op]
        public static bool imm(OpKind src)
            => immsigned(src) || immdirect(src) || immspecial(src);            

        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source operand kind</param>
        [MethodImpl(Inline), Op]
        public static bool register(OpKind src)
            => src == OpKind.Register;  
    }
}