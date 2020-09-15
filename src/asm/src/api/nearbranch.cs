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
        public static AsmBranchTarget nearbranch(W16 w, Address16 src)
            => asm.target(BranchTargetKind.Near, BranchTargetWidth.Branch16, src);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget nearbranch(W32 w, Address32 src)
            => asm.target(BranchTargetKind.Near, BranchTargetWidth.Branch32, src);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget nearbranch(W64 w, Address64 src)
            => asm.target(BranchTargetKind.Near, BranchTargetWidth.Branch64, src);
    }
}