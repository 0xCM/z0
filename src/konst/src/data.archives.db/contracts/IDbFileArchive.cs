//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDbFileArchive : IFileArchive
    {
        IDbPaths DbPaths {get;}

        FS.FolderPath TableRoot();

        FS.FolderPath SourceRoot();

        FS.FolderPath StageRoot();

        FS.FolderPath DocRoot();

        FS.FolderPath SourceRoot<S>(S subject);

        FS.FolderPath StageRoot<S>(S subject);

        FS.FileExt DefaultTableExt
            => ArchiveFileKinds.Csv;

        FS.FolderPath LogRoot()
            =>  DbPaths.DbRoot + FS.folder("logs");

        FS.FolderPath LogDir<S>(S subject)
            => LogRoot() + FS.folder(subject.ToString());

        FS.FilePath Log<S>(string id, S subject)
            => LogDir(subject) + FS.file(id, ArchiveFileKinds.Log);

        FS.FilePath Document<S>(string id, S subject, FS.FileExt ext);

        FS.FilePath Document<S>(PartId part, S subject, FS.FileExt ext);

        FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt type);

        FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt a, FS.FileExt b);

        FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt ext);

        FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt a, FS.FileExt b);

        FS.FilePath Table(string id);

        FS.FilePath Table(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table(a.TableId),
                    () => Table(t.Name));

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null);

        FS.FilePath Table<S>(Type t, S subject)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table<S>(a.TableId, subject, DefaultTableExt),
                    () => Table<S>(t.Name, subject, DefaultTableExt));

        FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>;

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext);

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table(part,  a.TableId, DefaultTableExt),
                    () => Table(part, t.Name, DefaultTableExt));

        Option<FilePath> deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        FS.FilePath[] Clear(FS.FolderName id);

        FS.FilePath[] Clear(string id);

    }

    public interface IDbFileArchive<H> : IDbFileArchive, IFileArchive<H>
        where H : IDbFileArchive<H>
    {

    }
}