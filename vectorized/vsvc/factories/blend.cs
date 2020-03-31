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
        public static Blend4x32x128<T> vblend4x32<T>(N128 w, T t = default)
            where T : unmanaged
                => Blend4x32x128<T>.Op;

        [MethodImpl(Inline)]
        public static Blend8x32x256<T> vblend8x32<T>(N256 w, T t = default)
            where T : unmanaged
                => Blend8x32x256<T>.Op;

        [MethodImpl(Inline)]
        public static Blend2x64x128<T> vblend2x64<T>(N128 w, T t = default)
            where T : unmanaged
                => Blend2x64x128<T>.Op;

        [MethodImpl(Inline)]
        public static Blend4x64x256<T> vblend4x64<T>(N256 w, T t = default)
            where T : unmanaged
                => Blend4x64x256<T>.Op;

        [MethodImpl(Inline)]
        public static Blend8x16x128<T> vblend8x16<T>(N128 w, T t = default)
            where T : unmanaged
                => Blend8x16x128<T>.Op;

        [MethodImpl(Inline)]
        public static Blend8x16x256<T> vblend8x16<T>(N256 w, T t = default)
            where T : unmanaged
                => Blend8x16x256<T>.Op;
    }
}