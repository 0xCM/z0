//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Asm.IceOpKind;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmBranch branch(in MemoryAddress @base, in IceInstruction ix, in AsmBranchTarget target)
            => new AsmBranch(@base, ix.IP, target, offset(ix.IP, (byte)ix.ByteLength, target.Address));

        [MethodImpl(Inline), Op]
        public static AsmBranch branch(in MemoryAddress @base, in IceInstruction src, byte index)
            => branch(@base, src, branch(src, index));

        [Op]
        public static AsmBranchTarget branch(in IceInstruction src, byte index)
        {
            var k = asm.kind(src, index);
            switch(k)
            {
                case NearBranch16:
                    return asm.target(BranchTargetKind.Near, src.NearBranch16, BranchTargetWidth.Branch16);
                case NearBranch32:
                    return asm.target(BranchTargetKind.Near, src.NearBranch32, BranchTargetWidth.Branch32);
                case NearBranch64:
                    return asm.target(BranchTargetKind.Near, src.NearBranch64, BranchTargetWidth.Branch64);
                case FarBranch16:
                    return asm.target(BranchTargetKind.Far, src.FarBranch16, BranchTargetWidth.Branch16, (Address16)src.FarBranchSelector);
                case FarBranch32:
                    return asm.target(BranchTargetKind.Far, src.FarBranch32, BranchTargetWidth.Branch32, (Address16)src.FarBranchSelector);
            }
            return AsmBranchTarget.Empty;
        }
    }
}