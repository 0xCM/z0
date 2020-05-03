//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static OpKind;

    partial struct AsmQuery : IAsmQuery
    {
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        public bool IsNearBranch(OpKind src)        
            => src == OpKind.NearBranch16
            || src == OpKind.NearBranch32
            || src == OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        public bool IsFarBranch(OpKind src)        
            => src == OpKind.FarBranch16
            || src == OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        public bool IsBranch(OpKind src)
            => IsNearBranch(src) || IsFarBranch(src);

        public IAsmBranch BranchInfo(MemoryAddress @base, Instruction src, int index)
        {
            var k = OperandKind(src,index);
            if(IsBranch(k))
            {
                switch(k)
                {
                    case NearBranch16:
                        return new AsmNearBranch(@base, src.IP, src.NearBranch16, 16);
                    case NearBranch32:
                        return new AsmNearBranch(@base, src.IP, src.NearBranch32, 32);
                    case NearBranch64:
                        return new AsmNearBranch(@base, src.IP, src.NearBranch64, 64);
                    case FarBranch16:
                        return new AsmFarBranch(@base, src.IP, src.FarBranch16, 16);
                    case FarBranch32:
                        return new AsmFarBranch(@base, src.IP, src.FarBranch32, 32);
                }
            }

            return AsmFarBranch.Empty;
        }
    }  
}