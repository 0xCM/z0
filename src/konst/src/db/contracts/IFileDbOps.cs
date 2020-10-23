//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFileDbOps : IFileArchiveOps, IFileDbPaths
    {
        FS.FilePath CopyToNotebook(FS.FilePath src, string notebook)
            => src.CopyTo(Notebook(notebook));
    }
}