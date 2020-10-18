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

    public class DbFiles : IDbFileArchive<DbFiles>
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

        public FS.FileExt DefaultTableExt
            => ArchiveFileKinds.Csv;

        public FS.FolderPath LogRoot()
            =>  DbPaths.DbRoot + FS.folder("logs");

        public FS.FolderPath LogDir(Subject subject)
            => LogRoot() + FS.folder(subject.Format());

        public FS.FilePath Log(string id, Subject subject)
            => LogDir(subject) + FS.file(id, ArchiveFileKinds.Log);

        public Files Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(list<FS.FilePath>()).Array();

        public Files Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(list<FS.FilePath>()).Array();

        public FS.FolderPath TableRoot()
            => Root + FS.folder(PN.Tables);

        public FS.FolderPath SourceRoot()
            => Root + FS.folder(PN.Sources);

        public FS.FolderPath ToolRoot()
            => Root + FS.folder(PN.Tools);

        public FS.FolderPath SourceRoot<S>(S subject)
            => DbPaths.SourceRoot() + FS.folder(subject.ToString());

        public FS.FolderPath StageRoot()
            => Root + FS.folder(PN.Stage);

        public FS.FolderPath StageRoot<S>(S subject)
            => DbPaths.StageRoot() + FS.folder(subject.ToString());

        public FS.FolderPath DocRoot()
            => Root + FS.folder(PN.Docs);

        public FS.FilePath Table(string id)
            => DbPaths.TableRoot() + FS.file(id,FileKindType.Csv);


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
        public FS.FilePath Table<D>(FS.FolderPath root, string id, D subject, FS.FileExt? type = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format("{0}.{1}", id, subject), type ?? X.Csv);

        public FS.FilePath Table(Type t, PartId part)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table(part,  a.TableId, DefaultTableExt),
                    () => Table(part, t.Name, DefaultTableExt));

        public FS.FilePath Table(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table(a.TableId),
                    () => Table(t.Name));

        public FS.FolderPath TableDir(string id)
            => DbPaths.TableRoot() + FS.folder(id);

        public FS.FolderPath TableDir(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => TableDir(a.TableId),
                    () => TableDir(t.Name));

        public FS.FilePath Table<S>(Type t, S subject)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table<S>(a.TableId, subject, DefaultTableExt),
                    () => Table<S>(t.Name, subject, DefaultTableExt));

        Option<FilePath> IDbFileArchive.Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt ext)
            => deposit<F,R,S>(Root, src, id, subject, ext);

        public FS.FilePath Doc(ApiHostUri host, Subject subject, FS.FileExt a, FS.FileExt b)
            =>  DbPaths.DocRoot() + FS.folder(subject.Format()) + FS.file(host, a, b);

        public FS.FilePath Doc(ApiHostUri host, Subject subject, FS.FileExt ext)
            => DbPaths.DocRoot() + FS.folder(subject.Format()) + FS.file(host, ext);

        public FS.FilePath Doc(ApiHostUri host, Subject s1, Subject s2,  FS.FileExt ext)
            => DbPaths.DocRoot() + FS.folder(s1.Format()) + FS.folder(s2.Format()) + FS.file(host, ext);

        public FS.FilePath Doc(ApiHostUri host, Subject s1, Subject s2, FS.FileExt a, FS.FileExt b)
            => DbPaths.DocRoot() + FS.folder(s1.Format()) + FS.folder(s2.Format()) + FS.file(host, a, b);

        public Files Docs(PartId part, Subject subject, FS.FileExt ext)
            => (DocRoot() + FS.folder(subject.Format())).Files(ext,true);

        public Files Docs(PartId part, Subject s1, Subject s2, FS.FileExt ext)
            => (DocRoot() + FS.folder(string.Concat(s1, Chars.Dot, s2))).Files(ext,true);

        public Files ClearDocs(PartId part, Subject subject, FS.FileExt ext)
        {
            var source = Docs(part, subject, ext);
            var target = list<FS.FilePath>(source.Count);
            foreach(var file in source)
                file.Delete().OnSuccess(f => target.Add(f));
            return target.ToArray();
        }

        public Files ClearDocs(PartId part, Subject s1, Subject s2, FS.FileExt ext)
        {
            var source = Docs(part, s1, s2, ext);
            var target = list<FS.FilePath>(source.Count);
            foreach(var file in source)
                file.Delete().OnSuccess(f => target.Add(f));
            return target.ToArray();
        }

        static Option<FilePath> deposit<F,R,S>(FS.FolderPath root, R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular
                => T.store<F,R>().Save(src, T.renderspec<F>(), (FS.dir(root.Name) + FS.folder(id) + FS.file($"{id}.{subject}",type)));
    }
}