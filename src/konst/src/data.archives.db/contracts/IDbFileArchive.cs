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

        FS.FolderPath ToolRoot();

        FS.FolderPath SourceRoot<S>(S subject);

        FS.FolderPath StageRoot<S>(S subject);

        FS.FileExt DefaultTableExt {get;}

        FS.FolderPath LogRoot();

        FS.FilePath Log(string id, Subject subject);

        FS.FilePath Doc(ApiHostUri host, Subject subject, FS.FileExt ext);

        FS.FilePath Doc(ApiHostUri host, Subject subject, FS.FileExt a, FS.FileExt b);

        FS.FilePath Doc(ApiHostUri host, Subject s1, Subject s2, FS.FileExt a, FS.FileExt b);

        FS.FilePath Doc(ApiHostUri host, Subject s1, Subject s2, FS.FileExt a);

        FS.FilePath Table(string id);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null);

        FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>;

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext);

        FS.FilePath Table(Type t);

        FS.FilePath Table<S>(Type t, S subject);

        FS.FilePath Table(Type t, PartId part);

        Option<FilePath> Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Files Clear(FS.FolderName id);

        Files Clear(string id);

        Files ClearDocs(PartId part, Subject subject, FS.FileExt ext);

        Files ClearDocs(PartId part, Subject s1, Subject s2, FS.FileExt ext);

        FS.FolderPath Tools(ToolId id)
            => ToolRoot() + FS.folder(id.Name);

        FS.FolderPath ToolOutput(ToolId id)
            => Tools(id) + FS.folder("output");
    }

    public interface IDbFileArchive<H> : IDbFileArchive, IFileArchive<H>
        where H : IDbFileArchive<H>
    {

    }
}