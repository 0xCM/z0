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

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableRow<T,C0,C1> row<T,C0,C1>(in T src, C0 c0, C1 c1)
            where T : struct
        {
            var dst = default(TableRow<T,C0,C1>);
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
            return dst;
        }

        [MethodImpl(Inline)]
        public static void row<T,C0,C1>(in T src, C0 c0, C1 c1, out TableRow<T,C0,C1> dst)
            where T : struct
        {
            dst = default;
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
        }

        [MethodImpl(Inline)]
        public static void row<T,C0,C1,C2>(in T src, C0 c0, C1 c1, C2 c2, out TableRow<T,C0,C1,C2> dst)
            where T : struct
        {
            dst = default;
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
            dst.Cell2 = c2;
        }

        [MethodImpl(Inline)]
        public static void row<T,C0,C1,C2,C3>(in T src, C0 c0, C1 c1, C2 c2,C3 c3, out TableRow<T,C0,C1,C2,C3> dst)
            where T : struct
        {
            dst = default;
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
            dst.Cell2 = c2;
            dst.Cell3 = c3;
        }

        [MethodImpl(Inline)]
        public static TableRow<T> row<T>(uint index, in T src)
            where T : struct
                => row(fields<T>(), index, src);

        [MethodImpl(Inline)]
        public static TableRow<T> row<T>(in TableFields fields, uint index, in T src)
            where T : struct
        {
            var dst = rowalloc<T>(fields.Count);
            fill(fields, index, src, ref dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static StringTableRow row(string[] data)
            => new StringTableRow(data);

        [MethodImpl(Inline), Op]
        public static StringTableRow<T> row<T>(params StringTableCell<T>[] cells)
            where T : ITextual
                => new StringTableRow<T>(cells);
    }
}