//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmBranchTarget<W>
        where W : unmanaged, IDataWidth<W>
    {
        public readonly MemoryAddress Address;

        public readonly BranchTargetKind Kind;

        public readonly Address16 Selector;

        [MethodImpl(Inline)]
        public AsmBranchTarget(BranchTargetKind kind, MemoryAddress dst, Address16? selector = null)
        {
            Kind = kind;
            Address = dst;
            Selector = selector ?? 0;
        }

        public BranchTargetWidth Width
            => (BranchTargetWidth)default(W).BitWidth;

        [MethodImpl(Inline)]
        public static implicit operator AsmBranchTarget(AsmBranchTarget<W> src)
            => new AsmBranchTarget(src.Address, src.Kind, src.Width, src.Selector);
    }
}