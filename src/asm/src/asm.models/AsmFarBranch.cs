//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmFarBranch
    {
        /// <summary>
        /// The target address
        /// </summary>
        public MemoryAddress Target {get;}

        /// <summary>
        /// The target size
        /// </summary>
        public BranchTargetWidth Width {get;}

        /// <summary>
        /// Specifies a branch target selector
        /// </summary>
        public Address16 Selector {get;}

        [MethodImpl(Inline)]
        public AsmFarBranch(MemoryAddress target, BranchTargetWidth width, Address16 selector)
        {
            Target = target;
            Selector = selector;
            Width = width;
        }
    }
}