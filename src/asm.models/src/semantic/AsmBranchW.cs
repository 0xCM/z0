//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmBranch<W>
        where W : unmanaged, IDataWidth<W>
    {
        public readonly BranchTargetKind Kind;

        public readonly MemoryAddress Target;

        public readonly Address16 Selector;

        [MethodImpl(Inline)]
        public AsmBranch(BranchTargetKind kind, MemoryAddress dst, Address16 selector)
        {
            Kind = kind;
            Target = dst;
            Selector = selector;
        }

        public BranchTargetWidth Width
            => (BranchTargetWidth)default(W).BitWidth;

        [MethodImpl(Inline)]
        public static implicit operator AsmBranch(AsmBranch<W> src)
            => new AsmBranch(src.Kind, src.Target, src.Width, src.Selector);
    }
}