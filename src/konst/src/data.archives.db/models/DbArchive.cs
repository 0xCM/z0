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

    using api = DbArchives;

    public struct DbArchive : IDbArchive<DbArchive>, IDbPaths
    {
        public ArchiveConfig Settings {get;}

        [MethodImpl(Inline)]
        public DbArchive(ArchiveConfig config)
        {
            Settings = config;
        }

        public FS.FolderPath Root
            => Settings.Root;

        FS.FolderPath IDbPaths.DbRoot
            => Settings.Root;

        public FS.FolderPath DbRoot
            => api.tableRoot(Root);

        public FS.FilePath[] Clear(FS.FolderName id)
            => (api.tableRoot(Root) + id).Clear(z.list<FS.FilePath>()).ToArray();

        public FS.FilePath[] Clear(string id)
            => (api.tableRoot(Root) + FS.folder(id)).Clear(z.list<FS.FilePath>()).ToArray();

        public FS.FolderPath TableRoot(string id)
            => api.tableRoot(Root) + FS.folder(id);

        public FS.FolderPath TableRoot()
            => api.tableRoot(Root);

        public FS.FilePath Table<S>(string id, S subject, string type = null)
            => api.table(Root, id, subject, type);

        public FS.FilePath Document<S>(string id, S subject, FS.FileExt type)
            => api.table(Root, id, subject, type.Name);

        public FS.FilePath Table(string id, PartId part, string type = null)
            => api.table(Root, id, part, type);

        public FS.FilePath Table(FS.FileName file)
            => api.table(Root, file);

        Option<FilePath> IDbArchive.deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            => api.deposit<F,R,S>(Root, src, id, subject, type);
    }
}