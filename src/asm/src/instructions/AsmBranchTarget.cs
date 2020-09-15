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
        public readonly BranchTargetKind Kind;

        public readonly MemoryAddress Address;

        public readonly Address16 Selector;

        [MethodImpl(Inline)]
        public AsmBranchTarget(BranchTargetKind kind, MemoryAddress address, Address16 selector)
        {
            Kind = kind;
            Address = address;
            Selector = selector;
        }

        public BranchTargetWidth Width
            => (BranchTargetWidth)default(W).BitWidth;

        [MethodImpl(Inline)]
        public static implicit operator AsmBranchTarget(AsmBranchTarget<W> src)
            => new AsmBranchTarget(src.Kind, src.Width, src.Address, src.Selector);
    }

    public readonly struct AsmBranchTarget
    {
        /// <summary>
        /// The target classifier, near or far
        /// </summary>
        public BranchTargetKind Kind {get;}

        /// <summary>
        /// The target size
        /// </summary>
        public BranchTargetWidth Size {get;}

        /// <summary>
        /// The target address
        /// </summary>
        public MemoryAddress TargetAddress {get;}

        /// <summary>
        /// Specifies a branch target selector, if far
        /// </summary>
        public Address16 Selector {get;}

        public bool IsEmpty
            => TargetAddress == 0;

        public bool IsNear
            => Kind == BranchTargetKind.Near;

        public bool IsFar
            => Kind == BranchTargetKind.Far;

        [MethodImpl(Inline)]
        public AsmBranchTarget(BranchTargetKind kind, BranchTargetWidth size, MemoryAddress address, Address16? selector = null)
        {
            Kind = kind;
            Size = size;
            TargetAddress = address;
            Selector = selector ?? 0;
        }

        public static AsmBranchTarget Empty
            => default;
    }
}