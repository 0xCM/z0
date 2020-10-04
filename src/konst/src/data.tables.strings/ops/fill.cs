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

    partial struct StringTables
    {
        [MethodImpl(Inline), Op]
        public static ref StringTable fill(StringTableRow[] src, ref StringTable dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StringTableRow fill(StringTableCell[] src, ref StringTableRow dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StringTableCell fill(in string src, ref StringTableCell dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref StringTableCell<T> fill<T>(in T src, ref StringTableCell<T> dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref StringTableCells<T> fill<T>(StringTableCell<T>[] src, ref StringTableCells<T> dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref StringTableRows<T> Fill<T>(StringTableRow<T>[] src, ref StringTableRows<T> dst)
        {
            dst.Fill(src);
            return ref dst;
        }
    }
}