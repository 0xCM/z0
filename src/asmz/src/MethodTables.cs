//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct MethodTables
    {
        [MethodImpl(Inline), Op]
        public static MethodTable from(Type src)
            => new MethodTable(src);
    }
}