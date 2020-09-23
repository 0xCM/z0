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
            where A : unmanaged, IAsmArg
                => new AsmArgs<A>(a);

        [MethodImpl(Inline)]
        public AsmArgs<A,B> args<A,B>(A a, B b)
            where A : unmanaged, IAsmArg
            where B : unmanaged, IAsmArg
                => new AsmArgs<A,B>(a, b);

        [MethodImpl(Inline)]
        public AsmArgs<A,B,C> args<A,B,C>(A a, B b, C c)
            where A : unmanaged, IAsmArg
            where B : unmanaged, IAsmArg
            where C : unmanaged, IAsmArg
                => new AsmArgs<A,B,C>(a, b, c);

        [MethodImpl(Inline)]
        public AsmArgs<A,B,C,D> args<A,B,C,D>(A a, B b, C c, D d)
            where A : unmanaged, IAsmArg<A>
            where B : unmanaged, IAsmArg<B>
            where C : unmanaged, IAsmArg<C>
            where D : unmanaged, IAsmArg<D>
                => new AsmArgs<A,B,C,D>(a, b, c, d);

    }
}