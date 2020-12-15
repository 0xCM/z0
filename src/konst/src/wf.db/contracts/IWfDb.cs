//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IWfDbOps : IArchiveOps, IWfDbPaths
    {
        FS.FilePath CopyToNotebook(FS.FilePath src, string notebook)
            => src.CopyTo(Notebook(notebook));

        FS.Files IArchiveOps.Clear(string id)
            => (TableRoot() + FS.folder(id)).Clear(list<FS.FilePath>()).Array();

        FS.Files IArchiveOps.Clear(FS.FolderName id)
            => (TableRoot() + id).Clear(list<FS.FilePath>()).Array();
    }

    [Free]
    public interface IWfDb : IWfDbPaths, IWfDbOps, IArchiveOps, IFileArchive
    {
        ITableArchive TableArchive<S>(S subject)
            => new FileDbTables<S>(this, subject);

        PartFiles PartFiles()
        {
            var parsed = ParsedExtractFiles();
            var hex = CapturedHexFiles();
            var asm = CapturedAsmFiles();
            return new PartFiles(parsed, hex, asm);
        }
    }
}