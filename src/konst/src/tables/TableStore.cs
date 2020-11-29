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
    public readonly struct TableStores
    {
        [MethodImpl(Inline), Op]
        public ITableStore service(FS.FolderPath root)
            => new TableStore(root);

        public static TableStore<F,R> service<F,R>()
            where F : unmanaged, Enum
            where R : struct, ITabular
                => default;

        public static Option<FilePath> save<F,R>(R[] src, FS.FilePath dst)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => service<F,R>().Save(src, dst);

        [MethodImpl(Inline)]
        public static ArchivedTable<T> archived<T>(FS.FilePath src)
            where T : struct
                => new ArchivedTable<T>(src);

        public static void deposit<F,T>(in RecordEmission<T> src, FS.FilePath dst, IRowFormatter<F> formatter, char delimiter = FieldDelimiter)
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
        }

        public static void deposit<E>(Dictionary<string,E> src, FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var header = text.concat("Seq". PadRight(10), SpacePipe, typeof(E).Name);

            using var writer = dst.Writer();
            writer.WriteLine(header);

            var keys = src.Keys.ToArray();
            Array.Sort(keys);
            for(var i=0; i<keys.Length; i++)
                writer.WriteLine(FormatSequential(i, src[keys[i]]));
        }

        /// <summary>
        /// Stores the dataset supplied by <see cref='Enums.index{E}'/>
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static void deposit<E>(in EnumLiteralDetails<E> src, FS.FilePath dst)
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