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
        public static KeyMapIndex<D,S> selectors<D,S>(KeyMap<D,S>[] src, S min, S max)
            where D : unmanaged, Enum
            where S : unmanaged
                => new KeyMapIndex<D,S>(src,min,max);
    }
}