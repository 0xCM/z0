//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Memories;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Add128<T> vadd<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Add128<T>);

        [MethodImpl(Inline)]
        public static Add256<T> vadd<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Add256<T>);

        [MethodImpl(Inline)]
        public static Sub128<T> vsub<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sub128<T>);

        [MethodImpl(Inline)]
        public static Sub256<T> vsub<T>(W256 w, T t = default)
            where T : unmanaged            
                => default(Sub256<T>);

        [MethodImpl(Inline)]
        public static Negate128<T> vnegate<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Negate128<T>);

        [MethodImpl(Inline)]
        public static Negate256<T> vnegate<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Negate256<T>);

        [MethodImpl(Inline)]
        public static Inc128<T> vinc<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Inc128<T>);

        [MethodImpl(Inline)]
        public static Inc256<T> vinc<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Inc256<T>);

        [MethodImpl(Inline)]
        public static Dec128<T> vdec<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Dec128<T>);

        [MethodImpl(Inline)]
        public static Dec256<T> vdec<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Dec256<T>);

        [MethodImpl(Inline)]
        public static Abs128<T> vabs<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Abs128<T>);

        [MethodImpl(Inline)]
        public static Abs256<T> vabs<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Abs256<T>);
    }
}