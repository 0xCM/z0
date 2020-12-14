//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    public interface IFileDbOps : IArchiveOps, IFileDbPaths
    {
        FS.FilePath CopyToNotebook(FS.FilePath src, string notebook)
            => src.CopyTo(Notebook(notebook));

        FS.Files IArchiveOps.Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(list<FS.FilePath>()).Array();

        FS.Files IArchiveOps.Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(list<FS.FilePath>()).Array();
    }
}