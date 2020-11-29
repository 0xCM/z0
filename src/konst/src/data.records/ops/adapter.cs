//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RowAdapter<T> adapter<T>(in RecordFields fields)
            where T : struct
                => new RowAdapter<T>(fields);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RowAdapter<T> adapter<T>()
            where T : struct
                => adapter<T>(fields<T>());
    }
}