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
        public static Branch target(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size)
            => new Branch(kind,dst,size);

        [MethodImpl(Inline), Op]
        public static Branch target(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size, Address16 selector)
            => new Branch(kind, dst, size, selector);

        [MethodImpl(Inline), Op]
        public static CallTarget target(MemoryAddress @base)
            => new CallTarget(@base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(string id, MemoryAddress @base)
            => new CallTarget(id, @base);
    }
}