//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines an enclosure for an operand triple
    /// </summary>
    public readonly struct Bound<T0,T1,T2>
        where T0 : unmanaged, IOperand
        where T1 : unmanaged, IOperand
        where T2 : unmanaged, IOperand
    {
        public readonly T0 A;

        public readonly T1 B;

        public readonly T2 C;

        [MethodImpl(Inline)]
        public Bound(T0 a, T1 b, T2 x)
        {
            A = a;
            B = b;
            C = x;
        }    
    }
}