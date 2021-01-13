//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmNearBranch nearbranch(W16 w, Address16 dst)
            => new AsmNearBranch(dst, BranchTargetWidth.Branch16);

        [MethodImpl(Inline), Op]
        public static AsmNearBranch nearbranch(W32 w, Address32 dst)
            => new AsmNearBranch(dst, BranchTargetWidth.Branch32);

        [MethodImpl(Inline), Op]
        public static AsmNearBranch nearbranch(W64 w, Address64 dst)
            => new AsmNearBranch(dst, BranchTargetWidth.Branch64);
    }
}