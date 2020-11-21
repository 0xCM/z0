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

    partial struct ApiSignatures
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ApiSig<A> define<A>(string identifier, A a = default)
            => new ApiSig<A>(identifier);

        [MethodImpl(Inline)]
        public static ApiSig<A,B> define<A,B>(string identifier, A a = default, B b = default)
            => new ApiSig<A,B>(identifier);

        [MethodImpl(Inline)]
        public static ApiSig<A,B,C> define<A,B,C>(string identifier, A a = default, B b = default, C c = default)
            => new ApiSig<A,B,C>(identifier);

        [MethodImpl(Inline)]
        public static ApiSig<A,B,C,D> define<A,B,C,D>(string identifier, A a = default, B b = default, C c = default, D d = default)
            => new ApiSig<A,B,C,D>(identifier);
    }
}