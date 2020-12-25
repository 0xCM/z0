//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static NearBranch nearbranch(W16 w, Address16 dst)
            => new NearBranch(dst, BranchTargetWidth.Branch16);

        [MethodImpl(Inline), Op]
        public static NearBranch nearbranch(W32 w, Address32 dst)
            => new NearBranch(dst, BranchTargetWidth.Branch32);

        [MethodImpl(Inline), Op]
        public static NearBranch nearbranch(W64 w, Address64 dst)
            => new NearBranch(dst, BranchTargetWidth.Branch64);
    }
}