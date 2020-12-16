//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    using api = Table;

    using X = FileExtensions;

    public struct TableArchive : ITableArchive, IWfService<TableArchive,ITableArchive>
    {
        IWfShell Wf;

        public FS.FolderPath Root {get; private set;}

        [MethodImpl(Inline)]
        internal TableArchive(IWfShell wf, FS.FolderPath? root = null)
        {
            Wf = wf;
            Root = root ?? Wf.Db().TableRoot();
        }

        public void Init(IWfShell wf)
        {
            Wf = wf;
            Root = wf.Db().TableRoot();
        }

        public void Clear()
            => TableArchives.clear(Root);

        public void Clear(FS.FolderName folder)
            => TableArchives.clear(Root, folder);

        public IEnumerable<FS.FilePath> Files()
            => Root.Files(X.Csv, true);

        public Option<FS.FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => TableArchives.deposit<F,R>(Root, src, name);

        public Option<FS.FilePath> Deposit<F,R>(R[] src, FS.FolderName folder, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => TableArchives.deposit<F,R>(Root, src, folder, name);

        public ArchivedRowset<T> Deposit<T,M,K>(T[] src, string header, Func<T,string> render, M m = default)
            where T : struct
            where M : struct, IDataModel
            where K : unmanaged
                => TableArchives.deposit<T,M,K>(Root, src, header, render, m);
    }
}