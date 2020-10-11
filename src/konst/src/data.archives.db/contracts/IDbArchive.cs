//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDbArchive : IFileArchive, IDbPaths
    {
        FS.FilePath[] Clear(FS.FolderName id);

        FS.FilePath[] Clear(string id);

        FS.FolderPath SourceRoot<S>(S subject)
            => SourceRoot() + FS.folder(subject.ToString());

        FS.FolderPath StageRoot<S>(S subject)
            => StageRoot() + FS.folder(subject.ToString());

        FS.FilePath Document<S>(string id, S subject, FS.FileExt ext);

        FS.FilePath Document<S>(PartId part, S subject, FS.FileExt ext)
            => DocRoot() + FS.folder(subject.ToString()) + FS.file(part, ext);

        FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt type)
            => DocRoot() + FS.folder(subject.ToString()) + FS.file(host, type);

        FS.FilePath Document<S>(ApiHostUri host, S subject, FS.FileExt a, FS.FileExt b);

        FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt ext)
            => DocRoot() + FS.folder(s1.ToString()) + FS.folder(s2.ToString()) + FS.file(host, ext);

        FS.FilePath Document<S1,S2>(ApiHostUri host, S1 s1, S2 s2, FS.FileExt a, FS.FileExt b)
            => DocRoot() + FS.folder(s1.ToString()) + FS.folder(s2.ToString()) + FS.file(host, a, b);

        FS.FilePath Table(string id)
            => TableRoot() + FS.file(id,FileKind.Csv);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => TableRoot() + FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, subject), ext ?? ArchiveExt.Csv);

        FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>
                => TableRoot() + FS.file(id, kind.Ext);

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null)
            => TableRoot() +  FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), ext ?? ArchiveExt.Csv);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableRoot() + FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), ext);

        Option<FilePath> deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;
    }

    public interface IDbArchive<H> : IDbArchive, IFileArchive<H>
        where H : IDbArchive<H>
    {

    }
}