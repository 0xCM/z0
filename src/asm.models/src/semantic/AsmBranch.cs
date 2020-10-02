//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AsmBranch
    {
        /// <summary>
        /// The target classifier, near or far
        /// </summary>
        public readonly BranchTargetKind Kind;

        /// <summary>
        /// The target address
        /// </summary>
        public readonly MemoryAddress Target;

        /// <summary>
        /// The target size
        /// </summary>
        public readonly BranchTargetWidth Size;

        /// <summary>
        /// Specifies a branch target selector, if far
        /// </summary>
        public readonly Address16 Selector;

        public bool IsEmpty
            => Target == 0;

        public bool IsNear
            => Kind == BranchTargetKind.Near;

        public bool IsFar
            => Kind == BranchTargetKind.Far;

        [MethodImpl(Inline)]
        public AsmBranch(BranchTargetKind kind, MemoryAddress dst, BranchTargetWidth size,  Address16? selector = null)
        {
            Kind = kind;
            Size = size;
            Target = dst;
            Selector = selector ?? 0;
        }

        public static AsmBranch Empty
            => default;
    }
}