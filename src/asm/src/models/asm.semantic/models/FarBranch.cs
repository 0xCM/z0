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
    public readonly struct FarBranch
    {
        /// <summary>
        /// The target address
        /// </summary>
        public readonly MemoryAddress Target;

        /// <summary>
        /// The target size
        /// </summary>
        public readonly BranchTargetWidth Width;

        /// <summary>
        /// Specifies a branch target selector
        /// </summary>
        public readonly Address16 Selector;

        [MethodImpl(Inline)]
        public FarBranch(MemoryAddress target, BranchTargetWidth width, Address16 selector)
        {
            Target = target;
            Selector = selector;
            Width = width;
        }
    }
}