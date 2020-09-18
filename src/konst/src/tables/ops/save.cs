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
        public Option<FilePath> save<F,R>(R[] src, FS.FilePath dst)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => store<F,R>().Save(src, dst);

        public static DataFlow<Rowset<T>,ArchivedTable<T>> save<T,M,K>(T[] src, TableArchive dst, string header, Func<T,string> render,  M m = default)
            where T : struct
            where M : struct, IDataModel
            where K : unmanaged, Enum
        {
            var path = FS.dir(dst.ArchiveRoot.Name) + FS.folder(m.Name) + FS.file(typeof(T).Name);
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
    }
}