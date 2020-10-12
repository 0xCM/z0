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
        public static AsmBranchTarget target(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size)
            => new AsmBranchTarget(dst,kind, size);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size, Address16 selector)
            => new AsmBranchTarget(dst, kind, size, selector);

        [MethodImpl(Inline), Op]
        public static AsmCallTarget target(MemoryAddress @base)
            => new AsmCallTarget(@base);

        [MethodImpl(Inline), Op]
        public static AsmCallTarget target(string id, MemoryAddress @base)
            => new AsmCallTarget(id, @base);
    }
}