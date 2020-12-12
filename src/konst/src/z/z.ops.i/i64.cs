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
        public static unsafe long i64(bool src)
            => memory.i64(src);

        [MethodImpl(Inline)]
        public static ref long i64<T>(in T src)
            => ref memory.i64(src);
    }

}