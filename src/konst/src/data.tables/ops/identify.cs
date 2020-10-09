//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableId identify<T>()
            where T : struct
                => typeof(T);

        [MethodImpl(Inline), Op]
        public static TableId identify(Type src)
            => new TableId(src);
    }
}