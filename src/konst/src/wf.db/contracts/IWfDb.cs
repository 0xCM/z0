//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfDb : IWfDbPaths, IArchiveOps, IFileArchive
    {
        ITableArchive TableArchive<S>(S subject)
            => new DbTables<S>(this, subject);

        FS.FilePath CopyToNotebook(FS.FilePath src, string notebook)
            => src.CopyTo(Notebook(notebook));

        FS.Files IArchiveOps.Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(list<FS.FilePath>()).Array();

        FS.Files IArchiveOps.Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(list<FS.FilePath>()).Array();
    }
}