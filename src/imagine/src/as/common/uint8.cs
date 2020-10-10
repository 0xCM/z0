//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsDeprecated
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte uint8<T>(T src)
            => As<T,byte>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte uint8<T>(ref T src)
            => ref As<T,byte>(ref src);

       [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte? uint8<T>(T? src)
            where T : unmanaged
                => As<T?, byte?>(ref src);
    }
}