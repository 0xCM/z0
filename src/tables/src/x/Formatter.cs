//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XTend
    {
        public static IRecordFormatter<T> Formatter<T>(this T src, ushort rowpad = 0)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(Tables.DefaultFieldWidth, rowpad);

        public static IRecordFormatter<T> Formatter<T>(this ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, ushort rowpad = 0)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(widths, rowpad);
    }
}