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

    using api = DbFiles;

    public struct DbArchive : IDbArchive<DbArchive>
    {
        public ArchiveConfig Settings {get;}

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public DbArchive(IWfShell wf, ArchiveConfig config)
        {
            Wf = wf;
            Settings = config;
            DbPaths = Z0.DbPaths.create(wf);
        }

        public FS.FolderPath Root
            => Settings.Root;

        public IDbPaths DbPaths {get;}

        public FS.FilePath[] Clear(FS.FolderName id)
            => (api.tableRoot(Root) + id).Clear(z.list<FS.FilePath>()).ToArray();

        public FS.FilePath[] Clear(string id)
            => (api.tableRoot(Root) + FS.folder(id)).Clear(z.list<FS.FilePath>()).ToArray();

        public FS.FolderPath TableRoot()
            => api.tableRoot(Root);

        public FS.FilePath Table<S>(string id, S subject, string type = null)
            => api.table(Root, id, subject, type);

        public FS.FilePath Document<S>(string id, S subject, FS.FileExt type)
            => api.table(Root, id, subject, type.Name);

        public FS.FilePath Table(string id, PartId part, string type = null)
            => api.table(Root, id, part, type);

        public FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => api.table(Root, part, id, ext);

        Option<FilePath> IDbArchive.deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            => api.deposit<F,R,S>(Root, src, id, subject, type);

        public FS.FolderPath SourceRoot()
            => api.sourceRoot(Root);

        public FS.FolderPath StageRoot()
            => api.stageRoot(Root);

        public FS.FilePath Document<S>(PartId part, S subject, FS.FileExt type)
            => DocRoot() + FS.folder(subject.ToString()) + FS.file(part, type);

        public FS.FolderPath DocRoot()
            => api.docRoot(Root);

        public FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt a, FS.FileExt b)
            => DocRoot() + FS.folder(subject.ToString()) + FS.file(host, a, b);
    }
}