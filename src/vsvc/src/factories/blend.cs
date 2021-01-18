//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static VServices;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Blend4x32x128<T> vblend4x32<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Blend4x32x128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Blend8x32x256<T> vblend8x32<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Blend8x32x256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Blend2x64x128<T> vblend2x64<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Blend2x64x128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Blend4x64x256<T> vblend4x64<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Blend4x64x256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Blend8x16x128<T> vblend8x16<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Blend8x16x128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Blend8x16x256<T> vblend8x16<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Blend8x16x256<T>);
    }
}