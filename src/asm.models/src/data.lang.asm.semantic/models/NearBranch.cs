//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct NearBranch
    {
        /// <summary>
        /// The target address
        /// </summary>
        public readonly MemoryAddress Target;

        /// <summary>
        /// The target size
        /// </summary>
        public readonly BranchTargetWidth Width;

        [MethodImpl(Inline)]
        public NearBranch(MemoryAddress target, BranchTargetWidth width)
        {
            Target = target;
            Width = width;
        }
    }
}