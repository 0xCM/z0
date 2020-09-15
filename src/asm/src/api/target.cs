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
        public static AsmBranchTarget target(BranchTargetKind kind, BranchTargetWidth size, MemoryAddress address)
            => new AsmBranchTarget(kind, size, address);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(BranchTargetKind kind, BranchTargetWidth size, MemoryAddress address, Address16 selector)
            => new AsmBranchTarget(kind, size, address, selector);

        [MethodImpl(Inline), Op]
        public static CallTarget target(MemoryAddress @base)
            => new CallTarget(@base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(string id, MemoryAddress @base)
            => new CallTarget(id, @base);
    }
}