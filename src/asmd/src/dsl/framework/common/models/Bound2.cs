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
    /// Defines an enclosure for a pair of operands
    /// </summary>
    public readonly struct Bound<T0,T1>
        where T0 : unmanaged, IOperand
        where T1 : unmanaged, IOperand
    {
        public readonly T0 A;

        public readonly T1 B;

        [MethodImpl(Inline)]
        public static implicit operator Bound<T0,T1>(in Paired<T0,T1> src)
            => new Bound<T0,T1>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public Bound(T0 arg0, T1 arg1)
        {
            A = arg0;
            B = arg1;
        }
    }
}