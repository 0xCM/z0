//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Record(TableId)]
    public struct AsmBranchTarget : IRecord<AsmBranchTarget>
    {
        public const string TableId = "asm.branch";

        /// <summary>
        /// The target address
        /// </summary>
        public MemoryAddress Address;

        /// <summary>
        /// The target classifier, near or far
        /// </summary>
        public AsmBranchTargetKind Kind;

        /// <summary>
        /// The target size
        /// </summary>
        public AsmBranchTargetWidth Size;

        /// <summary>
        /// Specifies a branch target selector, if far
        /// </summary>
        public Address16 Selector;

        [MethodImpl(Inline)]
        public AsmBranchTarget(MemoryAddress dst, AsmBranchTargetKind kind, AsmBranchTargetWidth size,  Address16? selector = null)
        {
            Kind = kind;
            Size = size;
            Address = dst;
            Selector = selector ?? 0;
        }

        public static AsmBranchTarget Empty
            => default;
    }
}