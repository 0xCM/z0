//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Args
    {

    }

    /// <summary>
    /// Captures an operand
    /// </summary>
    public struct Args<A> : IAsmOperands<Args<A>,A>
        where A : unmanaged, IAsmOp
    {
        public A _A;

        [MethodImpl(Inline)]
        public Args(A a)
            => _A = a;

        public A this[N0 n]
        {
            [MethodImpl(Inline)]
            get => _A;
        }

        [MethodImpl(Inline)]
        public static implicit operator Args<A>(A src)
            => new Args<A>(src);
    }

    /// <summary>
    /// Captures an operand pair
    /// </summary>
    public struct Args<A,B>: IAsmOperands<Args<A,B>,A,B>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
    {
        A _A;

        B _B;

        [MethodImpl(Inline)]
        public Args(A a, B b)
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
        public static implicit operator Args<A,B>((A a, B b) src)
            => new Args<A,B>(src.a,src.b);

        [MethodImpl(Inline)]
        public static implicit operator Args<A,B>(Paired<A,B> src)
            => new Args<A,B>(src.Left, src.Right);
    }

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
   }

    /// <summary>
    /// Captures an operand quartet
    /// </summary>
    public struct Args<A,B,C,D> : IAsmOperands<Args<A,B,C,D>,A,B,C,D>
        where A : unmanaged, IAsmOp
        where B : unmanaged, IAsmOp
        where C : unmanaged, IAsmOp
        where D : unmanaged, IAsmOp
    {
        A _A;

        B _B;

        C _C;

        D _D;

        [MethodImpl(Inline)]
        public Args(A a, B b, C c, D d)
        {
            _A = a;
            _B = b;
            _C = c;
            _D = d;
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

        public D this[N3 n]
        {
            [MethodImpl(Inline)]
            get => _D;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out A a, out B b, out C c, out D d)
        {
            a = _A;
            b = _B;
            c = _C;
            d = _D;
        }

        [MethodImpl(Inline)]
        public static implicit operator Args<A,B,C,D>((A a, B b, C c, D d) src)
            => new Args<A,B,C,D>(src.a, src.b, src.c, src.d);
    }
}