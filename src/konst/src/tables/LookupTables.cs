//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct LookupTables
    {
        [MethodImpl(Inline)]
        static LuFx64<K> luFx<K>(TableSpan<ulong> index, TableSpan<K> values)
            where K : unmanaged
                => new LuFx64<K>(index,values);
    }
}