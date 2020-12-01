//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmSemantic
    {
        [MethodImpl(Inline)]
        public Args<A> args<A>(A a)
            where A : unmanaged
                => new Args<A>(a);

        [MethodImpl(Inline)]
        public Args<A,B> args<A,B>(A a, B b)
            where A : unmanaged
            where B : unmanaged
                => new Args<A,B>(a, b);

        [MethodImpl(Inline)]
        public Args<A,B,C> args<A,B,C>(A a, B b, C c)
            where A : unmanaged
            where B : unmanaged
            where C : unmanaged
                => new Args<A,B,C>(a, b, c);

        [MethodImpl(Inline)]
        public Args<A,B,C,D> args<A,B,C,D>(A a, B b, C c, D d)
            where A : unmanaged
            where B : unmanaged
            where C : unmanaged
            where D : unmanaged
                => new Args<A,B,C,D>(a, b, c, d);
    }
}