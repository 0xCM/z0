//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static unsafe byte @byte(bool src)
            => memory.@byte(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte @byte<T>(in T src)
            where T : unmanaged
                => ref memory.@byte(src);

        [MethodImpl(Inline), Op]
        public static unsafe byte @byte(in ulong src, byte index)
            => memory.@byte(src);
    }
}