//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static OpKind;

    partial struct AsmQuery : TSemanticQuery
    {
        [MethodImpl(Inline), Op]
        public bool IsCall(Instruction src)
            => src.Mnemonic == Mnemonic.Call;
        
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public bool IsNearBranch(OpKind src)        
            => src == OpKind.NearBranch16
            || src == OpKind.NearBranch32
            || src == OpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public bool IsFarBranch(OpKind src)        
            => src == OpKind.FarBranch16
            || src == OpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        [MethodImpl(Inline), Op]
        public bool IsBranch(OpKind src)
            => IsNearBranch(src) || IsFarBranch(src);

        public AsmBranchTarget BranchTarget(Instruction src, int index)
        {
            var k = OperandKind(src, index);
            switch(k)
            {
                case NearBranch16:
                    return AsmBranchTarget.Define(BranchTargetKind.Near, BranchTargetSize.Branch16, src.NearBranch16);
                case NearBranch32:
                    return AsmBranchTarget.Define(BranchTargetKind.Near, BranchTargetSize.Branch32, src.NearBranch32);
                case NearBranch64:
                    return AsmBranchTarget.Define(BranchTargetKind.Near, BranchTargetSize.Branch64, src.NearBranch64);
                case FarBranch16:
                    return AsmBranchTarget.Define(BranchTargetKind.Far, BranchTargetSize.Branch16, src.FarBranch16, src.FarBranchSelector);
                case FarBranch32:
                    return AsmBranchTarget.Define(BranchTargetKind.Far, BranchTargetSize.Branch32, src.FarBranch32, src.FarBranchSelector);
            }
            return AsmBranchTarget.Empty;
        }

        public AsmBranchInfo BranchInfo(MemoryAddress @base, Instruction src, int index)
            => AsmBranchInfo.Define(@base, src, BranchTarget(src,index));        

    }  
}