//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    using X = FileExtensions;

    public struct DbTables<S> : ITableArchive
    {
        public IWfDb Db {get;}

        public S Subject {get;}

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        internal DbTables(IWfDb archive, S subject)
        {
            Db = archive;
            Subject = subject;
            Root = archive.TableDir(subject.ToString());
        }

        public void Clear()
            => Root.Clear();

        public void Clear(FS.FolderName folder)
            => (FS.dir(Root.Name) + folder).Clear();

        public IEnumerable<FS.FilePath> Files()
            => Root.Files(X.Csv, true);

        public Option<FS.FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => TableArchives.deposit<F,R>(Root, src, name);
    }
}