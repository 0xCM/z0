//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NearBranch
    {
        /// <summary>
        /// The target address
        /// </summary>
        public MemoryAddress Target {get;}

        /// <summary>
        /// The target size
        /// </summary>
        public BranchTargetWidth Width {get;}

        [MethodImpl(Inline)]
        public NearBranch(MemoryAddress target, BranchTargetWidth width)
        {
            Target = target;
            Width = width;
        }
    }
}