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
        const byte DefaultFieldWidth = 24;

        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="spec">The format spec</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static RecordFormatter<T> formatter<T>(RowFormatSpec spec)
            where T : struct, IRecord<T>
                => new RecordFormatter<T>(spec);

        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="widths">The column widths</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordFormatter<T> formatter<T>(ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => formatter<T>(rowspec<T>(widths));

        /// <summary>
        /// Defines a <typeparamref name='T'/> record formatter
        /// </summary>
        /// <param name="widths">The column widths</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordFormatter<T> formatter<T>(byte fieldwidth = DefaultFieldWidth)
            where T : struct, IRecord<T>
                => formatter<T>(rowspec<T>(fieldwidth));

        public static IRecordFormatter<T> formatter<E,T>()
            where E : unmanaged, Enum
            where T : struct, IRecord<T>
                => formatter<T>(rowspec<T>(Enums.numeric<E,byte>()));

        public static Func<T,string> formatFx<T>(byte? fieldwidth = null)
            where T : struct, IRecord<T>
        {
            string fx(T input)
            {
                return formatter<T>(fieldwidth ?? DefaultFieldWidth).Format(input);
            }
            return fx;
        }
    }

    partial class XTend
    {
        public static IRecordFormatter<T> RecordFormatter<T>(this ReadOnlySpan<T> src)
            where T : struct, IRecord<T>
                => Tables.formatter<T>();

        public static IRecordFormatter<T> RecordFormatter<T>(this Span<T> src)
            where T : struct, IRecord<T>
                => Tables.formatter<T>();

        public static IRecordFormatter<T> RecordFormatter<T>(this Index<T> src)
            where T : struct, IRecord<T>
                => Tables.formatter<T>();

        public static IRecordFormatter<T> RecordFormatter<T>(this T[] src)
            where T : struct, IRecord<T>
                => Tables.formatter<T>();

        public static IRecordFormatter<T> Formatter<T>(this T src)
            where T : struct, IRecord<T>
                => Tables.formatter<T>();

        public static IRecordFormatter<T> RecordFormatter<T>(this ReadOnlySpan<T> src, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(widths);

        public static IRecordFormatter<T> RecordFormatter<T>(this Span<T> src, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(widths);

        public static IRecordFormatter<T> RecordFormatter<T>(this Index<T> src, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(widths);

        public static IRecordFormatter<T> RecordFormatter<T>(this T[] src, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(widths);

        public static IRecordFormatter<T> Formatter<T>(this T src, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => Tables.formatter<T>(widths);
    }
}