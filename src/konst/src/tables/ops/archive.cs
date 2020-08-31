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

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static TableArchive archive(FolderPath root)
            => new TableArchive(root);

        [MethodImpl(Inline)]
        public static ArchivedTable<T> archived<T>(FilePath src)
            where T : struct
                => new ArchivedTable<T>(src);

        [MethodImpl(Inline)]
        public static WfDataFlow<Rowset<T>,ArchivedTable<T>> archive<T,M,K>(Rowset<T> src, TableArchive dst, M m = default)
            where T : struct
            where M : struct, IDataModel
            where K : unmanaged, Enum
        {
            var path = dst.ArchiveRoot + FolderName.Define(m.Name) + FileName.define(typeof(T).Name);
            return (src, new ArchivedTable<T>(path));
        }

        public static WfDataFlow<Rowset<T>,ArchivedTable<T>> archive<T,M,K>(T[] src, TableArchive dst, string header, Func<T,string> render,  M m = default)
            where T : struct
            where M : struct, IDataModel
            where K : unmanaged, Enum
        {
            var path = dst.ArchiveRoot + FolderName.Define(m.Name) + FileName.define(typeof(T).Name);
            var records = z.span(src);
            var count = records.Length;

            using var writer = path.Writer();
            writer.WriteLine(header);

            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref z.skip(records, i);
                writer.WriteLine(render(record));
            }
            return (Table.rowset<T>(src), new ArchivedTable<T>(path));
        }

        [MethodImpl(Inline)]
        public static WfDataFlow<Rowset<T>, ArchivedTable<T>> archive<T>(Rowset<T> src, FilePath dst)
            where T : struct
                => (src, new ArchivedTable<T>(dst));
    }
}