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
    /// Defines an enclosure for an operand quartet
    /// </summary>
    public readonly struct AsmArgs<T0,T1,T2,T3>
        where T0 : unmanaged, IAsmOperand
        where T1 : unmanaged, IAsmOperand
        where T2 : unmanaged, IAsmOperand
    {
        public readonly T0 A;

        public readonly T1 B;

        public readonly T2 C;

        public readonly T3 D;

        [MethodImpl(Inline)]
        public AsmArgs(T0 a, T1 b, T2 c, T3 d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }
}