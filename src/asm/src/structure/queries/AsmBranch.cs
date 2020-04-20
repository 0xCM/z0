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

    public class AsmBranch
    {
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        public static bool near(OpKind src)        
            => src == OpKind.NearBranch16
            || src == OpKind.NearBranch32
            || src == OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        public static bool far(OpKind src)        
            => src == OpKind.FarBranch16
            || src == OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline)]
        public static bool any(OpKind src)
            => near(src) || far(src);

        public static Option<AsmBranchInfo> describe(Instruction src, int index, ulong baseaddress)
        {
            var k = AsmInstruction.kind(src,index);
            if(AsmBranch.any(k))
            {
                switch(k)
                {
                    case NearBranch16:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch16, 16, true);
                    case NearBranch32:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch32, 32, true);
                    case NearBranch64:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch64, 64, true);
                    case FarBranch16:
                        return AsmBranchInfo.Define(baseaddress, src.FarBranch16, 16,  false);
                    case FarBranch32:
                        return AsmBranchInfo.Define(baseaddress, src.FarBranch32, 32, false);
                }
            }

            return none<AsmBranchInfo>();
        }
    }
}