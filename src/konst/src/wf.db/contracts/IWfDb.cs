//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWfDb :  IWfDbPaths, IFileArchive
    {
        WfExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>;

        IToolDb ToolDb()
            => new ToolDb(Wf);

        ITableArchive TableArchive<S>(S subject)
            => new DbTables<S>(this, subject);

        FS.Files IFileArchive.Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(root.list<FS.FilePath>()).Array();

        FS.Files IFileArchive.Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(root.list<FS.FilePath>()).Array();
    }
}