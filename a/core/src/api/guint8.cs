//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T generic<T>(byte src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref byte src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static byte uint8<T>(T src)
            => As.uint8(src);

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(ref T src)
            => ref As.uint8(ref src);

        [MethodImpl(Inline)]
        public static byte? uint8<T>(T? src)
            where T : unmanaged
                => As.uint8(src);
    }
}