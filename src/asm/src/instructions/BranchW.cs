//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Branch<W>
        where W : unmanaged, IDataWidth<W>
    {
        public readonly BranchTargetKind Kind;

        public readonly MemoryAddress Target;

        public readonly Address16 Selector;

        [MethodImpl(Inline)]
        public Branch(BranchTargetKind kind, MemoryAddress dst, Address16 selector)
        {
            Kind = kind;
            Target = dst;
            Selector = selector;
        }

        public BranchTargetWidth Width
            => (BranchTargetWidth)default(W).BitWidth;

        [MethodImpl(Inline)]
        public static implicit operator Branch(Branch<W> src)
            => new Branch(src.Kind, src.Target, src.Width, src.Selector);
    }
}