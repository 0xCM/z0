//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static FarBranch farbranch(W16 w, Address16 dst, Address16 selector)
            => new FarBranch(dst, BranchTargetWidth.Branch16, selector);

        [MethodImpl(Inline), Op]
        public static FarBranch farbranch(W32 w, Address32 dst, Address16 selector)
            => new FarBranch(dst, BranchTargetWidth.Branch32, selector);
    }
}