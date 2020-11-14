//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    using api = Table;

    using X = ArchiveFileKinds;

    public readonly struct DbTables : IDbTableArchive
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public static IDbTableArchive create(FS.FolderPath root)
            => new DbTables(root);

        [MethodImpl(Inline)]
        internal DbTables(FS.FolderPath root)
            => Root = root;

        public void Clear()
            => Root.Clear();

        public void Clear(FS.FolderName folder)
            => (FS.dir(Root.Name) + folder).Clear();

        public IEnumerable<FS.FilePath> Files()
            => Root.Files(X.Csv, true);

        public Option<FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), Root + FS.file(name.Name));

        public Option<FilePath> Deposit<F,R>(R[] src, FS.FolderName folder, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => api.store<F,R>().Save(src, api.renderspec<F>(), (FS.dir(Root.Name) + folder) + name);

        public DataFlow<Rowset<T>,ArchivedTable<T>> Deposit<T,M,K>(T[] src, string header, Func<T,string> render,  M m = default)
            where T : struct
            where M : struct, IDataModel
            where K : unmanaged, Enum
        {
            var path = Root + FS.folder(m.Name) + FS.file(typeof(T).Name);
            var records = z.span(src);
            var count = records.Length;

            using var writer = path.Writer();
            writer.WriteLine(header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(render(z.skip(records, i)));

            return (Table.rowset<T>(src), new ArchivedTable<T>(path));
        }
    }
}