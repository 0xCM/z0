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

        FS.FilePath Document<S>(string id, S subject, FS.FileExt type);

        FS.FilePath Table<S>(string id, S subject, string type = null);

        FS.FilePath Table(string id, PartId part, string type = null);

        FS.FilePath Table(FS.FileName file);

        Option<FilePath> deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

    }

    public interface IDbArchive<H> : IDbArchive, IFileArchive<H>
        where H : IDbArchive<H>
    {

    }
}