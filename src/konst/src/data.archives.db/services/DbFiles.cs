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

    using X = ArchiveFileKinds;
    using PN = DbPartitionNames;
    using T = Table;

    public struct DbFiles : IDbFileArchive<DbFiles>
    {
        public ArchiveConfig Settings {get;}

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        internal DbFiles(IWfShell wf, ArchiveConfig config)
        {
            Wf = wf;
            Settings = config;
            DbPaths = Z0.DbPaths.create(wf);
        }

        [MethodImpl(Inline)]
        internal DbFiles(IWfShell wf, DbPaths paths)
        {
            Wf = wf;
            DbPaths = paths;
            Settings = new ArchiveConfig(DbPaths.DbRoot);
        }

        public FS.FolderPath Root
            => Settings.Root;

        public IDbPaths DbPaths {get;}

        public FS.FilePath[] Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(z.list<FS.FilePath>()).ToArray();

        public FS.FilePath[] Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(z.list<FS.FilePath>()).ToArray();

        public FS.FolderPath TableRoot()
            => Root + FS.folder(PN.Tables);

        public FS.FolderPath SourceRoot()
            => Root + FS.folder(PN.Sources);

        public FS.FolderPath SourceRoot<S>(S subject)
            => DbPaths.SourceRoot() + FS.folder(subject.ToString());

        public FS.FolderPath StageRoot()
            => Root + FS.folder(PN.Stage);

        public FS.FolderPath StageRoot<S>(S subject)
            => DbPaths.StageRoot() + FS.folder(subject.ToString());

        public FS.FolderPath DocRoot()
            => Root + FS.folder(PN.Docs);

        public FS.FilePath Table(string id)
            => DbPaths.TableRoot() + FS.file(id,FileKind.Csv);

        public FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>
                => DbPaths.TableRoot() + FS.file(id, kind.Ext);

        public FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => Table<S>(Root, id, subject, ext);

        public FS.FilePath Table(string id, PartId part, FS.FileExt? type = null)
            => TableRoot() +  FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), type ?? X.Csv);

        public FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableRoot() + FS.folder(id) + FS.file(part.Format(),  ext);

        [MethodImpl(Inline), Op]
        FS.FilePath Table<D>(FS.FolderPath root, string id, D subject, FS.FileExt? type = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format("{0}.{1}", id, subject), type ?? X.Csv);

        Option<FilePath> IDbFileArchive.deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt ext)
            => deposit<F,R,S>(Root, src, id, subject, ext);

        public FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt ext)
            => DbPaths.DocRoot() + FS.folder(subject.ToString()) + FS.file(host, ext);

        public FS.FilePath Document<S>(string id, S subject, FS.FileExt ext)
            => DocRoot() + FS.folder(id) + FS.file(text.format("{0}.{1}", id, subject), ext);

        public FS.FilePath Document<S>(PartId part, S subject, FS.FileExt ext)
            => DocRoot() + FS.folder(subject.ToString()) + FS.file(part, ext);

        public FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt a, FS.FileExt b)
            => DocRoot() + FS.folder(subject.ToString()) + FS.file(host, a, b);

        public FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt ext)
            => DbPaths.DocRoot() + FS.folder(s1.ToString()) + FS.folder(s2.ToString()) + FS.file(host, ext);

        public FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt a, FS.FileExt b)
            => DbPaths.DocRoot() + FS.folder(s1.ToString()) + FS.folder(s2.ToString()) + FS.file(host, a, b);

        static Option<FilePath> deposit<F,R,S>(FS.FolderPath root, R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => T.store<F,R>().Save(src, T.renderspec<F>(), (FS.dir(root.Name) + FS.folder(id) + FS.file($"{id}.{subject}",type)));
    }
}