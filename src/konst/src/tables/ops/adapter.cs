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
        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static RowAdapter<T> adapter<T>(in TableFields fields)
        //     where T : struct
        //         => new RowAdapter<T>(fields);

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static RowAdapter<T> adapter<T>()
        //     where T : struct
        //         => adapter<T>(Table.index<T>());
    }
}