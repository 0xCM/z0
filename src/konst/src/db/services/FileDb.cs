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

    using PN = DbNames;
    using T = Table;

    public class FileDb : IFileDb, IFileArchiveOps, IFileArchive
    {
        public ArchiveConfig Settings {get;}

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        internal FileDb(IWfShell wf, FileDbPaths paths)
        {
            Wf = wf;
            Settings = new ArchiveConfig(paths.Root);
        }

        public FS.FolderPath Root
            => Settings.Root;

        public Files Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(list<FS.FilePath>()).Array();

        public Files Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(list<FS.FilePath>()).Array();

        Option<FilePath> IFileArchiveOps.Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt ext)
            => deposit<F,R,S>(Root, src, id, subject, ext);

       static Option<FilePath> deposit<F,R,S>(FS.FolderPath root, R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => T.store<F,R>().Save(src, T.renderspec<F>(), (FS.dir(root.Name) + FS.folder(id) + FS.file($"{id}.{subject}",type)));
        public FS.FolderPath TableRoot()
            => Root + FS.folder(PN.Tables);
    }
}