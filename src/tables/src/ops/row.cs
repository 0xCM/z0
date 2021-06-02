//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Tables
    {
        // public static DynamicRow<T> row<T>(uint index, in T src)
        //     where T : struct, IRecord<T>
        //         => row(fields<T>(), index, src);

        // public static DynamicRow<T> row<T>(in RecordFields fields, uint index, in T src)
        //     where T : struct, IRecord<T>
        // {
        //     var dst = DynamicRows.row<T>(fields.Count);
        //     load(fields, index, src, ref dst);
        //     return dst;
        // }

        // public static DynamicRow<T> row<T>(in T src)
        //     where T : struct, IRecord<T>
        //         => adapter<T>().Adapt(src).Adapted;

        // public static DynamicRow<T> row<T>(in T src, in RowAdapter<T> adapter)
        //     where T : struct, IRecord<T>
        //         => adapter.Adapt(src).Adapted;

        // public static DynamicRow<T> row<T>(in T src, in RecordFields fields)
        //     where T : struct, IRecord<T>
        //         => adapter<T>(fields).Adapt(src).Adapted;
    }
}