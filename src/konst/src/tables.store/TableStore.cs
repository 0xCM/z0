//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct TableStore
    {
        [MethodImpl(Inline), Op]
        public static TableEmission<F,T> emission<F,T>(T[] src, FS.FilePath dst, F f = default)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new TableEmission<F,T>(src,dst);

        public static DataFlow<TableEmission<F,T>, FS.FilePath> deposit<F,T>(in TableEmission<F,T> src, FS.FilePath dst, IRowFormatter<F> formatter, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
        {
            var header = Table.header<F>(delimiter);
            var count = src.RowCount;
            var rows = src.View;

            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);

            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(rows,i)));
            return (src,dst);
        }

        public static DataFlow<Dictionary<string,E>,FS.FilePath> deposit<E>(Dictionary<string,E> src, FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var header = text.concat("Seq". PadRight(10), SpacePipe, typeof(E).Name);

            using var writer = dst.Writer();
            writer.WriteLine(header);

            var keys = src.Keys.ToArray();
            Array.Sort(keys);
            for(var i=0; i<keys.Length; i++)
                writer.WriteLine(FormatSequential(i, src[keys[i]]));
            return (src,dst);
        }

        /// <summary>
        /// Stores the dataset supplied by <see cref='Enums.index{E}'/>
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static DataFlow<EnumLiteralDetails<E>,FS.FilePath> deposit<E>(in EnumLiteralDetails<E> src, FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var name = typeof(E).Name;
            var header = text.concat("Sequence". PadRight(10), SpacePipe, typeof(E).Name);
            using var writer = dst.Writer();
            writer.WriteLine(header);

            for(var i=0; i<src.Length; i++)
            {
                var literal = src[i];
                writer.WriteLine(FormatSequential((int)literal.Position, literal.LiteralValue));
            }
            return (src,dst);
        }

        public static Option<FilePath> save<R,F>(R[] data, TableRenderSpec<F> format, FormatFunctions.FormatDelimited<R> fx, FilePath dst, FileWriteMode mode = Overwrite)
            where F : unmanaged, Enum
            where R : struct
       {
            if(data == null || data.Length == 0)
                return Option.none<FilePath>();

            try
            {
                dst.FolderPath.Create();
                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = format.EmitHeader && (overwrite || !dst.Exists);

                using var writer = dst.Writer(mode);

                if(emitHeader)
                    writer.WriteLine(format.FormatHeader());

                z.iter(data, r => writer.WriteLine(fx(r,format.Delimiter)));
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        static string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight(10), SpacePipe, value.ToString());
    }
}