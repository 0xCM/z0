//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmNearBranch
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
        public AsmNearBranch(MemoryAddress target, BranchTargetWidth width)
        {
            Target = target;
            Width = width;
        }
    }
}