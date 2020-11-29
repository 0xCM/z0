//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Records
    {
        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(uint cells)
            where T : struct
                => new DynamicRow<T>(0, default(T), sys.alloc<dynamic>(cells));

        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(uint index, in T src)
            where T : struct
                => row(fields<T>(), index, src);

        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in RecordFields fields, uint index, in T src)
            where T : struct
        {
            var dst = Records.row<T>(fields.Count);
            load(fields, index, src, ref dst);
            return dst;
        }

        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in T src)
            where T : struct
                => adapter<T>().Adapt(src).Adapted;

        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in T src, in RowAdapter<T> adapter)
            where T : struct
                => adapter.Adapt(src).Adapted;

        [Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(in T src, in RecordFields fields)
            where T : struct
                => adapter<T>(fields).Adapt(src).Adapted;
    }
}