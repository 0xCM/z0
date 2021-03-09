//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    using F = EnumDatasetField;

    partial struct Records
    {
        public static void emit<E,T>(ReadOnlySpan<EnumLiteralInfo<E,T>> src, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(EnumDatasets.header<F>());
            var buffer = Buffers.text();

            var dataset = EnumDatasets.create<E,T>();
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(EnumDatasets.format(src[i],buffer));
        }

        /// <summary>
        /// Loads a <see cref='DynamicRows{T}' /> index from a specified source <see cref='ReadOnlySpan{T}'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The record type</typeparam>
        public static Count emit<T>(DynamicRows<T> src, FS.FilePath dst, RowFormatSpec spec)
            where T : struct, IRecord<T>
        {
            var count = src.Count;
            var data = src.View;
            using var writer = dst.Writer();
            writer.WriteLine(format(spec.Header));
            var buffer = Buffers.text();
            for(var i=0; i<count; i++)
            {
                render(skip(data,i), spec, buffer);
                writer.WriteLine(buffer.Emit());
            }

            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst, RowFormatSpec spec)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Records.formatter<T>(spec);
            using var writer = dst.Writer();
            writer.WriteLine(format(spec.Header));
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));

            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst, byte? fieldwidth = null, bool append = false)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Records.formatter<T>(fieldwidth ?? DefaultFieldWidth);
            var header = (dst.Exists && append) ? false : true;

            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(formatter.FormatHeader());

            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));

            return count;
        }

        public static Count emit<T>(Span<T> src, FS.FilePath dst, byte? fieldwidth = null)
            where T : struct, IRecord<T>
                => emit(src.ReadOnly(), dst, fieldwidth);

        public static Count emit<T>(Index<T> src, FS.FilePath dst, byte? fieldwidth = null)
            where T : struct, IRecord<T>
                => emit(src.View, dst, fieldwidth);

        public static Count emit<T>(Span<T> src, FS.FilePath dst, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => emit(src.ReadOnly(), dst, rowspec<T>(widths));

        public static Count emit<T>(Index<T> src, FS.FilePath dst, RowFormatSpec spec)
            where T : struct, IRecord<T>
                => emit(src.View, dst, spec);

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => emit(src, dst, rowspec<T>(widths));
    }
}