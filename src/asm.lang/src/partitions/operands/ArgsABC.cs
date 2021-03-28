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
    /// Captures an operand triple
    /// </summary>
    public struct Args<A,B,C> : IAsmOperands<Args<A,B,C>,A,B,C>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
    {
        A _A;

        B _B;

        C _C;

        [MethodImpl(Inline)]
        public Args(A a, B b, C c)
        {
            _A = a;
            _B = b;
            _C = c;
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

        public C this[N2 n]
        {
            [MethodImpl(Inline)]
            get => _C;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out A a, out B b, out C c)
        {
            a = _A;
            b = _B;
            c = _C;
        }

        [MethodImpl(Inline)]
        public static implicit operator Args<A,B,C>(Tripled<A,B,C> src)
            => new Args<A,B,C>(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public static implicit operator Args<A,B,C>((A a, B b, C c) src)
            => new Args<A,B,C>(src.a, src.b, src.c);

        [MethodImpl(Inline)]
        public static implicit operator Args(Args<A,B,C> src)
            => new Args(src._A, src._B, src._C);
   }
}