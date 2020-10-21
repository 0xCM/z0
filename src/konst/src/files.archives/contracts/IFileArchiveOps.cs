//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IFileArchiveOps : IFileArchive
    {
       Option<FilePath> Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Files Clear(FS.FolderName id);

        Files Clear(string id);

        IEnumerable<FS.FolderPath> Directories()
            => ApiFiles.directories(Root, true);

        IEnumerable<FS.FilePath> Files()
            => ApiFiles.files(Root, true);

        IEnumerable<FS.FilePath> Files(FS.FileExt ext)
            => ApiFiles.files(Root, true);
    }
}