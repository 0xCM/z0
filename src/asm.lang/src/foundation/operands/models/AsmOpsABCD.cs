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
    /// Captures an operand quartet
    /// </summary>
    public struct AsmOps<A,B,C,D> : IAsmOps<AsmOps<A,B,C,D>,A,B,C,D>
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
        public AsmOps(A a, B b, C c, D d)
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
        public static implicit operator AsmOps<A,B,C,D>((A a, B b, C c, D d) src)
            => new AsmOps<A,B,C,D>(src.a, src.b, src.c, src.d);
    }
}