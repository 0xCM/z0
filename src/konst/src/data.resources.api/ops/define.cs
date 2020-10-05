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

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static TextResource<E> define<E>(E id, MemoryAddress location, string value)
            where E : unmanaged, Enum
                => new TextResource<E>(id,location,value);
    }
}