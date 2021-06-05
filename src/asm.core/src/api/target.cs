//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(AsmBranchTargetKind kind, MemoryAddress dst, AsmBranchTargetWidth size, Address16 selector)
            => new AsmBranchTarget(dst, kind, size, selector);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(AsmBranchTargetKind kind, MemoryAddress dst, AsmBranchTargetWidth size)
            => new AsmBranchTarget(dst,kind, size);
    }
}