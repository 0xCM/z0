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

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(in MemoryAddress @base, in Instruction ix, in AsmBranchTarget target)
            => new AsmBranchInfo(ix, @base, ix.IP, target, fxOffset(ix.IP, (byte)ix.ByteLength, target.TargetAddress));

        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(in MemoryAddress @base, in Instruction src, byte index)
            => branch(@base, src, branchTarget(src,index));
    }
}