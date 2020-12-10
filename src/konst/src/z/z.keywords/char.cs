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
        public static char @char(bool src)
            => memory.@char(src);

        [MethodImpl(Inline)]
        public static ref char @char<E>(in E src)
            where E : unmanaged
                => ref memory.@char(src);
    }
}