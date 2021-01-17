//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = Kinds;

    partial class XKinds
    {
        [MethodImpl(Inline)]
        public static BinaryClass<W> Fixed<W>(this BinaryClass src)
            where W : unmanaged, ITypeWidth => default;

        [MethodImpl(Inline)]
        public static BinaryClass<T> As<T>(this BinaryClass src)
             where T : unmanaged => default;

        [MethodImpl(Inline)]
        public static K.UnaryFunc<A,R> As<A,R>(this K.UnaryFunc f,A a = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static K.BinaryFunc<A,B,R> As<A,B,R>(this K.BinaryFunc f,A a = default, B b = default, R r = default)
            => default;

        [MethodImpl(Inline)]
        public static K.TernaryFunc<A,B,C,R> As<A,B,C,R>(this K.TernaryFunc f,A a = default, B b = default, C c = default,  R r = default)
            => default;
    }
}