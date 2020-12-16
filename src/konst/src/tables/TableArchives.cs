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

    using api = Table;

    [ApiHost]
    public readonly struct TableArchives
    {
        public static void clear(FS.FolderPath root)
            => root.Clear();

        public static void clear(FS.FolderPath root, FS.FolderName folder)
            => (root + folder).Clear();

        public static Option<FS.FilePath> deposit<F,R,S>(FS.FolderPath root, R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => TableArchives.service<F,R>().Save(src, Table.renderspec<F>(), (FS.dir(root.Name) + FS.folder(id) + FS.file($"{id}.{subject}",type)));

        [MethodImpl(Inline), Op]
        public ITableArchive service(IWfShell wf, FS.FolderPath? root = null)
            => new TableArchive(wf, root);

        public static TableArchive<F,R> service<F,R>()
            where F : unmanaged
            where R : struct, ITabular
                => default;

        public static Option<FS.FilePath> deposit<F,R>(R[] src, FS.FilePath dst)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => service<F,R>().Save(src, dst);

        [MethodImpl(Inline)]
        public static ArchivedTable<T> archived<T>(FS.FilePath src)
            where T : struct
                => new ArchivedTable<T>(src);

        public static Option<FS.FilePath> deposit<F,R>(FS.FolderPath root, R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => deposit(src, api.renderspec<F>(), root + FS.file(name.Name));

        public static Option<FS.FilePath> deposit<F,R>(FS.FolderPath root, R[] src, FS.FolderName folder, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => deposit(src, api.renderspec<F>(), (root + folder) + name);

        public static Option<FS.FilePath> deposit<F,R>(R[] data, TableRenderSpec<F> spec, FS.FilePath dst, FileWriteMode mode = Overwrite)
            where F : unmanaged
            where R : struct, ITabular
        {
            if(data == null || data.Length == 0)
                return Option.none<FS.FilePath>();

            try
            {
                dst.FolderPath.Create();
                var overwrite = mode == FileWriteMode.Overwrite;
                var emitHeader = spec.EmitHeader && (overwrite || !dst.Exists);

                using var writer = dst.Writer(mode);

                if(emitHeader)
                    writer.WriteLine(spec.FormatHeader());

                z.iter(data, r => writer.WriteLine(r.DelimitedText(spec.Delimiter)));
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FS.FilePath>();
            }
        }

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

        public static ArchivedRowset<T> deposit<T,M,K>(FS.FolderPath root, T[] src, string header, Func<T,string> render,  M m = default)
            where T : struct
            where M : struct, IDataModel
            where K : unmanaged
        {
            var path = root + FS.folder(m.Name) + FS.file(typeof(T).Name);
            var records = z.span(src);
            var count = records.Length;

            using var writer = path.Writer();
            writer.WriteLine(header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(render(skip(records, i)));

            return (TableRows.rowset<T>(src), new ArchivedTable<T>(path));
        }


        static string FormatSequential<E>(int seq, E value)
            => text.concat(seq.ToString().PadRight(10), SpacePipe, value.ToString());
    }
}