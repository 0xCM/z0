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
    /// Defines an enclosure for a pair of operands
    /// </summary>
    public readonly struct AsmArgs<T0,T1>
        where T0 : unmanaged, IOperand
        where T1 : unmanaged, IOperand
    {
        public readonly T0 A;

        public readonly T1 B;

        [MethodImpl(Inline)]
        public AsmArgs(T0 arg0, T1 arg1)
        {
            A = arg0;
            B = arg1;
        }
    }
}