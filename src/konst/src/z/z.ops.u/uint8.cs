//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static byte uint8<T>(T src)
            => memory.uint8(src);

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(ref T src)
            => ref memory.uint8(ref src);

        [MethodImpl(Inline)]
        public static byte? uint8<T>(T? src)
            where T : struct
                => memory.uint8(ref src);
    }
}