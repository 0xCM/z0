//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDbArchive : IFileArchive
    {
        FS.FolderPath DbRoot {get;}

        FS.FilePath[] Clear(FS.FolderName id);

        FS.FilePath[] Clear(string id);

        FS.FolderPath TableRoot(string id);

        FS.FolderPath TableRoot();

        FS.FolderPath SourceRoot();

        FS.FolderPath StageRoot();

        FS.FolderPath DocRoot();

        FS.FolderPath SourceRoot<S>(S subject)
            => SourceRoot() + FS.folder(subject.ToString());

        FS.FolderPath StageRoot<S>(S subject)
            => StageRoot() + FS.folder(subject.ToString());

        FS.FilePath Document<S>(string id, S subject, FS.FileExt type);

        FS.FilePath Document<S>(PartId part, S subject, FS.FileExt type);

        FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt a, FS.FileExt b);

        FS.FilePath Table<S>(string id, S subject, string type = null);

        FS.FilePath Table(string id, PartId part, string type = null);

        FS.FilePath Table(FS.FileName file);

        Option<FilePath> deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt ext);

        FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt a, FS.FileExt b);

    }

    public interface IDbArchive<H> : IDbArchive, IFileArchive<H>
        where H : IDbArchive<H>
    {

    }
}