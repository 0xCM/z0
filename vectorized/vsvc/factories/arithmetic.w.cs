//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Add128<T> vadd<T>(W128 w, T t = default)
            where T : unmanaged
                => Add128<T>.Op;

        [MethodImpl(Inline)]
        public static Add256<T> vadd<T>(W256 w, T t = default)
            where T : unmanaged
                => Add256<T>.Op;

        [MethodImpl(Inline)]
        public static Sub128<T> vsub<T>(W128 w, T t = default)
            where T : unmanaged
                => Sub128<T>.Op;

        [MethodImpl(Inline)]
        public static Sub256<T> vsub<T>(W256 w, T t = default)
            where T : unmanaged            
                => Sub256<T>.Op;

        [MethodImpl(Inline)]
        public static Negate128<T> vnegate<T>(W128 w, T t = default)
            where T : unmanaged
                => Negate128<T>.Op;

        [MethodImpl(Inline)]
        public static Negate256<T> vnegate<T>(W256 w, T t = default)
            where T : unmanaged
                => Negate256<T>.Op;

        [MethodImpl(Inline)]
        public static Inc128<T> vinc<T>(W128 w, T t = default)
            where T : unmanaged
                => Inc128<T>.Op;

        [MethodImpl(Inline)]
        public static Inc256<T> vinc<T>(W256 w, T t = default)
            where T : unmanaged
                => Inc256<T>.Op;

        [MethodImpl(Inline)]
        public static Dec128<T> vdec<T>(W128 w, T t = default)
            where T : unmanaged
                => Dec128<T>.Op;

        [MethodImpl(Inline)]
        public static Dec256<T> vdec<T>(W256 w, T t = default)
            where T : unmanaged
                => Dec256<T>.Op;

        [MethodImpl(Inline)]
        public static Abs128<T> vabs<T>(W128 w, T t = default)
            where T : unmanaged
                => Abs128<T>.Op;

        [MethodImpl(Inline)]
        public static Abs256<T> vabs<T>(W256 w, T t = default)
            where T : unmanaged
                => Abs256<T>.Op;
    }
}