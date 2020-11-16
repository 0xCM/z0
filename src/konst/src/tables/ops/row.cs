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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TableRow<T> row<T>(uint cells)
            where T : struct
                => new TableRow<T>(0,default(T), sys.alloc<object>(cells));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TableRow<T> row<T>(uint index, in T src)
            where T : struct
                => row(Table.index<T>(), index, src);

        [MethodImpl(Inline)]
        public static TableRow<T> row<T>(in TableFields fields, uint index, in T src)
            where T : struct
        {
            var dst = row<T>(fields.Count);
            load(fields, index, src, ref dst);
            return dst;
        }

        public static TableRow<T> row<T>(in T src)
            where T : struct
                => adapter<T>().Adapt(src).Adapted;

        [MethodImpl(Inline)]
        public static TableRow<T> row<T>(in T src, in RowAdapter<T> adapter)
            where T : struct
                => adapter.Adapt(src).Adapted;

        public static TableRow<T> row<T>(in T src, in TableFields fields)
            where T : struct
                => adapter<T>(fields).Adapt(src).Adapted;

        [MethodImpl(Inline), Op]
        public static StringTableRow row(string[] data)
            => new StringTableRow(data);

        [MethodImpl(Inline), Op]
        public static StringTableRow<T> row<T>(params StringTableCell<T>[] cells)
            where T : ITextual
                => new StringTableRow<T>(cells);

        [MethodImpl(Inline)]
        public static TableRow<C0,C1,C2> row<C0,C1,C2>(in C0 c0, in C1 c1, in C2 c2)
        {
            var dst = default(TableRow<C0,C1,C2>);
            dst.Col0 = c0;
            dst.Col1 = c1;
            dst.Col2 = c2;
            return dst;
        }

        [MethodImpl(Inline)]
        public static TableRow<C0,C1,C2,C3> row<C0,C1,C2,C3>(in C0 c0, in C1 c1, in C2 c2, in C3 c3)
        {
            var dst = default(TableRow<C0,C1,C2,C3>);
            dst.Col0 = c0;
            dst.Col1 = c1;
            dst.Col2 = c2;
            dst.Col3 = c3;
            return dst;
        }

        [MethodImpl(Inline)]
        public static TableRow<C0,C1,C2,C3,C4> row<C0,C1,C2,C3,C4>(in C0 c0, in C1 c1, in C2 c2, in C3 c3, in C4 c4)
        {
            var dst = default(TableRow<C0,C1,C2,C3,C4>);
            dst.Col0 = c0;
            dst.Col1 = c1;
            dst.Col2 = c2;
            dst.Col3 = c3;
            dst.Col4 = c4;
            return dst;
        }
    }
}