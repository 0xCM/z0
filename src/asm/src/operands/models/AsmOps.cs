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
    /// Captures an operand
    /// </summary>
    public struct AsmOps<T>
        where T : unmanaged, IAsmOperand
    {
        public T A;

        [MethodImpl(Inline)]
        public AsmOps(T arg0)
            => A = arg0;
    }

    /// <summary>
    /// Captures an operand pair
    /// </summary>
    public struct AsmOps<T0,T1>
        where T0 : unmanaged, IAsmOperand
        where T1 : unmanaged, IAsmOperand
    {
        public T0 A;

        public T1 B;

        [MethodImpl(Inline)]
        public static implicit operator AsmOps<T0,T1>((T0 a, T1 b) src)
            => new AsmOps<T0,T1>(src.a,src.b);

        [MethodImpl(Inline)]
        public AsmOps(T0 arg0, T1 arg1)
        {
            A = arg0;
            B = arg1;
        }
    }

    /// <summary>
    /// Captures an operand triple
    /// </summary>
    public struct AsmOps<T0,T1,T2>
        where T0 : unmanaged, IAsmOperand
        where T1 : unmanaged, IAsmOperand
        where T2 : unmanaged, IAsmOperand
    {
        public T0 A;

        public T1 B;

        public T2 C;

        [MethodImpl(Inline)]
        public AsmOps(T0 a, T1 b, T2 x)
        {
            A = a;
            B = b;
            C = x;
        }
    }

    /// <summary>
    /// Captures an operand quartet
    /// </summary>
    public struct AsmOps<T0,T1,T2,T3>
        where T0 : unmanaged, IAsmOperand<T0>
        where T1 : unmanaged, IAsmOperand<T1>
        where T2 : unmanaged, IAsmOperand<T2>
    {
        public T0 A;

        public T1 B;

        public T2 C;

        public T3 D;

        [MethodImpl(Inline)]
        public AsmOps(T0 a, T1 b, T2 c, T3 d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }
}