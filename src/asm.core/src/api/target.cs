//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size, Address16 selector)
            => new AsmBranchTarget(dst, kind, size, selector);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size)
            => new AsmBranchTarget(dst,kind, size);
    }
}