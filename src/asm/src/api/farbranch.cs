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
        public static AsmBranchTarget farbranch(W16 w, ushort src, Address16 selector)
            => asm.target(BranchTargetKind.Far, BranchTargetWidth.Branch16, src, selector);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget farbranch(W32 w, uint src, Address16 selector)
            => asm.target(BranchTargetKind.Far, BranchTargetWidth.Branch32, src, selector);
    }
}