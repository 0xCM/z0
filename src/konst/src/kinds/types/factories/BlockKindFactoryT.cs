//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Kinds
    {
        [KindFactory, Closures(Closure)]
        public static BlockedKind<T> block<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedKind<W,T> block<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => default;

        [KindFactory, Closures(Closure)]
        public static BlockedKind<W16,T> block<T>(W16 w, T t = default)
            where T : unmanaged
                => default;

        [KindFactory, Closures(Closure)]
        public static BlockedKind<W32,T> block<T>(W32 w, T t = default)
            where T : unmanaged
                => default;

        [KindFactory, Closures(Closure)]
        public static BlockedKind<W64,T> block<T>(W64 w, T t = default)
            where T : unmanaged
                => default;

        [KindFactory, Closures(Closure)]
        public static BlockedKind<W128,T> block<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [KindFactory, Closures(Closure)]
        public static BlockedKind<W256,T> block<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [KindFactory, Closures(Closure)]
        public static BlockedKind<W512,T> block<T>(W512 w, T t = default)
            where T : unmanaged
                => default;
    }
}