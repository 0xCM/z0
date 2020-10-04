//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.TableRows)]
    public readonly partial struct TableRows
    {

        [MethodImpl(Inline)]
        public static TableRow<T,C0,C1> define<T,C0,C1>(in T src, C0 c0, C1 c1)
            where T : struct
        {
            var dst = default(TableRow<T,C0,C1>);
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
            return dst;
        }

        [MethodImpl(Inline)]
        public static void define<T,C0,C1>(in T src, C0 c0, C1 c1, out TableRow<T,C0,C1> dst)
            where T : struct
        {
            dst = default;
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
        }

        [MethodImpl(Inline)]
        public static void define<T,C0,C1,C2>(in T src, C0 c0, C1 c1, C2 c2, out TableRow<T,C0,C1,C2> dst)
            where T : struct
        {
            dst = default;
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
            dst.Cell2 = c2;
        }

        [MethodImpl(Inline)]
        public static void define<T,C0,C1,C2,C3>(in T src, C0 c0, C1 c1, C2 c2,C3 c3, out TableRow<T,C0,C1,C2,C3> dst)
            where T : struct
        {
            dst = default;
            dst.Source = src;
            dst.Cell0 = c0;
            dst.Cell1 = c1;
            dst.Cell2 = c2;
            dst.Cell3 = c3;
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