//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Text;

    using static Root;
    using static core;

    partial struct Tables
    {
        public static Count emit<T>(ReadOnlySpan<T> src, RowFormatSpec spec, StreamWriter dst)
            where T : struct, IRecord<T>
        {
            var formatter = Tables.formatter<T>(spec);
            var count = src.Length;
            dst.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            dst.WriteLine(formatter.Format(skip(src,i)));
            return count;
        }

        public static Count emit<T>(ReadOnlySpan<T> src, StreamWriter dst)
            where T : struct, IRecord<T>
                => emit(src,Tables.rowspec<T>(DefaultFieldWidth),dst);

        public static Count emit<T>(ReadOnlySpan<T> src, RowFormatSpec spec, Encoding encoding, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            using var writer = dst.Writer(encoding);
            return emit(src, spec, writer);
        }

        public static void emit<T>(ReadOnlySpan<T> src, Action<string> dst)
            where T : struct, IRecord<T>
        {
            var f = formatter<T>(rowspec<T>());
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst(f.Format(skip(src,i)));
        }

        public static Count emit<T>(ReadOnlySpan<T> src, RowFormatSpec spec, FS.FilePath dst)
            where T : struct, IRecord<T>
                => emit(src, spec, Encoding.UTF8, dst);

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst, ReadOnlySpan<byte> widths)
            where T : struct, IRecord<T>
                => emit(src, rowspec<T>(widths, z16), Encoding.UTF8, dst);

        public static Count emit<T>(ReadOnlySpan<T> src, Encoding encoding, FS.FilePath dst)
            where T : struct, IRecord<T>
        {
            using var writer = dst.Writer(encoding);
            return emit(src, writer);
        }

        public static Count emit<T>(ReadOnlySpan<T> src, FS.FilePath dst)
            where T : struct, IRecord<T>
                => emit(src, Encoding.UTF8, dst);

        public static Count emit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct, IRecord<T>
                => emit(src, widths, z16, Encoding.UTF8, dst);

        public static Count emit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, ushort rowpad, Encoding encoding, FS.FilePath dst)
            where T : struct, IRecord<T>
                => emit(src, Tables.rowspec<T>(widths, rowpad), dst);

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
    }
}