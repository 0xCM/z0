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
        [Op]
        public static AsmBranchTarget branchTarget(Instruction src, byte index)
        {
            var k = asm.kind(src, index);
            switch(k)
            {
                case NearBranch16:
                    return asm.target(BranchTargetKind.Near, BranchTargetSize.Branch16, src.NearBranch16);
                case NearBranch32:
                    return asm.target(BranchTargetKind.Near, BranchTargetSize.Branch32, src.NearBranch32);
                case NearBranch64:
                    return asm.target(BranchTargetKind.Near, BranchTargetSize.Branch64, src.NearBranch64);
                case FarBranch16:
                    return asm.target(BranchTargetKind.Far, BranchTargetSize.Branch16, src.FarBranch16, src.FarBranchSelector);
                case FarBranch32:
                    return asm.target(BranchTargetKind.Far, BranchTargetSize.Branch32, src.FarBranch32, src.FarBranchSelector);
            }
            return AsmBranchTarget.Empty;
        }
    }
}