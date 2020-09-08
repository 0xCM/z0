//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm;
    
    using static Konst;
    
    partial struct asm
    {
        /// <summary>
        /// Defines a branch target
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="size"></param>
        /// <param name="address"></param>
        /// <param name="selector"></param>
        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(BranchTargetKind kind, BranchTargetSize size, MemoryAddress address, ushort selector = 0)
            => new AsmBranchTarget(kind, size, address, selector);
    }
}