//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct Signatures
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Sig<A> define<A>(string identifier, A a = default)
            => new Sig<A>(identifier);

        [MethodImpl(Inline)]
        public static Sig<A,B> define<A,B>(string identifier, A a = default, B b = default)
            => new Sig<A,B>(identifier);

        [MethodImpl(Inline)]
        public static Sig<A,B,C> define<A,B,C>(string identifier, A a = default, B b = default, C c = default)
            => new Sig<A,B,C>(identifier);

        [MethodImpl(Inline)]
        public static Sig<A,B,C,D> define<A,B,C,D>(string identifier, A a = default, B b = default, C c = default, D d = default)
            => new Sig<A,B,C,D>(identifier);
    }
}