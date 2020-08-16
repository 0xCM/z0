//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines an enclosure for a single operand
    /// </summary>
    public readonly struct AsmArgs<T>
        where T : unmanaged, IAsmOperand
    {
        public readonly T A;

        [MethodImpl(Inline)]
        public AsmArgs(T arg0)
            => A = arg0;
    }
}