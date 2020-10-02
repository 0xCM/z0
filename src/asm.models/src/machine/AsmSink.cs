//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly ref partial struct AsmSink
    {
        [MethodImpl(Inline)]
        public AsmArgs<A> args<A>(A a)
            where A : unmanaged
                => new AsmArgs<A>(a);

        [MethodImpl(Inline)]
        public AsmArgs<A,B> args<A,B>(A a, B b)
            where A : unmanaged
            where B : unmanaged
                => new AsmArgs<A,B>(a, b);

        [MethodImpl(Inline)]
        public AsmArgs<A,B,C> args<A,B,C>(A a, B b, C c)
            where A : unmanaged
            where B : unmanaged
            where C : unmanaged
                => new AsmArgs<A,B,C>(a, b, c);

        [MethodImpl(Inline)]
        public AsmArgs<A,B,C,D> args<A,B,C,D>(A a, B b, C c, D d)
            where A : unmanaged
            where B : unmanaged
            where C : unmanaged
            where D : unmanaged
                => new AsmArgs<A,B,C,D>(a, b, c, d);
    }
}