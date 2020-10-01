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
    public struct AsmArgs<A> : IAsmOperands<AsmArgs<A>,A>
        where A : unmanaged
    {
        public A _A;

        [MethodImpl(Inline)]
        public static implicit operator AsmArgs<A>(A src)
            => new AsmArgs<A>(src);

        [MethodImpl(Inline)]
        public AsmArgs(A a)
            => _A = a;

        public A this[N0 n]
        {
            [MethodImpl(Inline)]
            get => _A;
        }
    }

    /// <summary>
    /// Captures an operand pair
    /// </summary>
    public struct AsmArgs<A,B>: IAsmOperands<AsmArgs<A,B>,A,B>
        where A : unmanaged
        where B : unmanaged
    {
        A _A;

        B _B;

        [MethodImpl(Inline)]
        public static implicit operator AsmArgs<A,B>((A a, B b) src)
            => new AsmArgs<A,B>(src.a,src.b);

        [MethodImpl(Inline)]
        public static implicit operator AsmArgs<A,B>(Paired<A,B> src)
            => new AsmArgs<A,B>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public AsmArgs(A a, B b)
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
    }

    /// <summary>
    /// Captures an operand triple
    /// </summary>
    public struct AsmArgs<A,B,C> : IAsmOperands<AsmArgs<A,B,C>,A,B,C>
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
    {
        A _A;

        B _B;

        C _C;

        [MethodImpl(Inline)]
        public static implicit operator AsmArgs<A,B,C>(Tripled<A,B,C> src)
            => new AsmArgs<A,B,C>(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public AsmArgs(A a, B b, C c)
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
   }

    /// <summary>
    /// Captures an operand quartet
    /// </summary>
    public struct AsmArgs<A,B,C,D> : IAsmOperands<AsmArgs<A,B,C,D>,A,B,C,D>
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged
    {
        A _A;

        B _B;

        C _C;

        D _D;

        [MethodImpl(Inline)]
        public AsmArgs(A a, B b, C c, D d)
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
    }
}