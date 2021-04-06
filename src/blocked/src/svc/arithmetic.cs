
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BSvcHosts;

    partial class BSvc
    {
        [MethodImpl(Inline)]
        public static Abs128<T> abs<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Abs128<T>);

        [MethodImpl(Inline)]
        public static Abs256<T> abs<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Abs256<T>);

        [MethodImpl(Inline)]
        public static Add128<T> add<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Add128<T>);

        [MethodImpl(Inline)]
        public static Add256<T> add<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Add256<T>);

        [MethodImpl(Inline)]
        public static Dec128<T> dec<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Dec128<T>);

        [MethodImpl(Inline)]
        public static Dec256<T> dec<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Dec256<T>);

        [MethodImpl(Inline)]
        public static Inc128<T> inc<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Inc128<T>);

        [MethodImpl(Inline)]
        public static Inc256<T> inc<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Inc256<T>);

        [MethodImpl(Inline)]
        public static Negate128<T> negate<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Negate128<T>);

        [MethodImpl(Inline)]
        public static Negate256<T> negate<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Negate256<T>);

        [MethodImpl(Inline)]
        public static Sub128<T> sub<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sub128<T>);

        [MethodImpl(Inline)]
        public static Sub256<T> sub<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Sub256<T>);
    }
}