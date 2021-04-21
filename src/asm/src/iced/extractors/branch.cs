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

    using BTK = AsmBranchTargetKind;
    using BTW = AsmBranchTargetWidth;

    partial struct IceExtractors
    {
        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(MemoryAddress @base, in IceInstruction src, in AsmBranchTarget target)
            => new AsmBranchInfo(@base, src.IP, target, AsmCore.offset(src.IP, (byte)src.ByteLength, target.Address));

        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(MemoryAddress @base, in IceInstruction src, byte index)
            => branch(@base, src, branch(src, index));

        [Op]
        public static AsmBranchTarget branch(in IceInstruction src, byte index)
        {
            var k = opkind(src, index);
            switch(k)
            {
                case NearBranch16:
                    return AsmCore.target(BTK.Near, src.NearBranch16, BTW.Branch16);
                case NearBranch32:
                    return AsmCore.target(BTK.Near, src.NearBranch32, BTW.Branch32);
                case NearBranch64:
                    return AsmCore.target(BTK.Near, src.NearBranch64, BTW.Branch64);
                case FarBranch16:
                    return AsmCore.target(BTK.Far, src.FarBranch16, BTW.Branch16, (Address16)src.FarBranchSelector);
                case FarBranch32:
                    return AsmCore.target(BTK.Far, src.FarBranch32, BTW.Branch32, (Address16)src.FarBranchSelector);
            }
            return AsmBranchTarget.Empty;
        }
    }
}