//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public interface IWfDb : IWfService, IWfDbPaths, IFileArchive
    {
        IToolDb ToolDb()
            => new ToolDb(Wf);

        ITableArchive TableArchive<S>(S subject)
            => new DbTables<S>(this, subject);

        FS.FilePath CopyToNotebook(FS.FilePath src, string notebook)
            => src.CopyTo(Notebook(notebook));

        FS.Files IFileArchive.Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(list<FS.FilePath>()).Array();

        FS.Files IFileArchive.Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(list<FS.FilePath>()).Array();
    }
}