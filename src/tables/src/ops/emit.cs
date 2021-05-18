//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static core;

    using F = EnumDatasetField;

    partial struct Tables
    {
        public static void emit<E,T>(ReadOnlySpan<EnumLiteralInfo<E,T>> src, FS.FilePath dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            using var writer = dst.Writer();
            writer.WriteLine(EnumDatasets.header<F>());
            var buffer = text.buffer();

            var dataset = EnumDatasets.create<E,T>();
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(EnumDatasets.format(src[i],buffer));
        }

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst, RowFormatSpec spec)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Tables.formatter<T>(spec);
            using var writer = dst.Writer();
            writer.WriteLine(format(spec.Header));
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));

            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, StreamWriter dst)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Tables.formatter<T>();
            for(var i=0; i<count; i++)
                dst.WriteLine(formatter.Format(skip(src,i)));
            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Tables.formatter<T>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));

            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Tables.formatter<T>(widths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));

            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, ITextBuffer dst)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Tables.formatter<T>();
            dst.AppendLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                dst.AppendLine(formatter.Format(skip(src,i)));

            return count;
        }

        public static Count emit<T>(T[] src, FS.FilePath dst, byte? fieldwidth = null, bool append = false)
            where T : struct, IRecord<T>
                => emit(@readonly(src), dst, fieldwidth, append);

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst, byte? fieldwidth = null, bool append = false)
            where T : struct, IRecord<T>
        {
            var count = src.Length;
            var formatter = Tables.formatter<T>(fieldwidth ?? DefaultFieldWidth);
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