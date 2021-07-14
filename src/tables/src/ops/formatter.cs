//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Tables
    {
        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="spec">The format spec</param>
        /// <typeparam name="T">The record type</typeparam>
        public static RecordFormatter<T> formatter<T>(RowFormatSpec spec)
            where T : struct
                => new RecordFormatter<T>(spec, adapter<T>());

        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="widths">The column widths</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordFormatter<T> formatter<T>(ReadOnlySpan<byte> widths, ushort rowpad = 0)
            where T : struct
                => formatter<T>(rowspec<T>(widths, rowpad));

        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="widths">The column widths</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordFormatter<T> formatter<T>(byte fieldwidth = DefaultFieldWidth, ushort rowpad = 0)
            where T : struct
                => formatter<T>(rowspec<T>(fieldwidth, rowpad));

        public static IRecordFormatter<T> formatter<E,T>(ushort rowpad = 0)
            where E : unmanaged, Enum
            where T : struct
                => formatter<T>(rowspec<T>(Enums.numeric<E,byte>(), rowpad));
    }
}