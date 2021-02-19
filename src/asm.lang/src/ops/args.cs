//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static Args<A> args<A>(A a)
            where A : unmanaged, IAsmOp
                => new Args<A>(a);

        [MethodImpl(Inline)]
        public static Args<A,B> args<A,B>(A a, B b)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
                => new Args<A,B>(a, b);

        [MethodImpl(Inline)]
        public static Args<A,B,C> args<A,B,C>(A a, B b, C c)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
            where C : unmanaged, IAsmOp
                => new Args<A,B,C>(a, b, c);

        [MethodImpl(Inline)]
        public static Args<A,B,C,D> args<A,B,C,D>(A a, B b, C c, D d)
            where A : unmanaged, IAsmOp
            where B : unmanaged, IAsmOp
            where C : unmanaged, IAsmOp
            where D : unmanaged, IAsmOp
                => new Args<A,B,C,D>(a, b, c, d);
    }
}