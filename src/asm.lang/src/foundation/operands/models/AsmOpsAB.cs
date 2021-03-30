//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures an operand pair
    /// </summary>
    public struct AsmOps<A,B>: IAsmOps<AsmOps<A,B>,A,B>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
    {
        A _A;

        B _B;

        [MethodImpl(Inline)]
        public AsmOps(A a, B b)
        {
            _A = a;
            _B = b;
        }

        public A this[N0 n]
        {
            [MethodImpl(Inline)]
            get => _A;
        }

        public B this[N1 n]
        {
            [MethodImpl(Inline)]
            get => _B;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out A a, out B b)
        {
            a = _A;
            b = _B;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmOps<A,B>((A a, B b) src)
            => new AsmOps<A,B>(src.a,src.b);

        [MethodImpl(Inline)]
        public static implicit operator AsmOps<A,B>(Paired<A,B> src)
            => new AsmOps<A,B>(src.Left, src.Right);
    }
}