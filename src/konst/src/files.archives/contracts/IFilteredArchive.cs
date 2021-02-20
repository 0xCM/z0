//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    public interface IFilteredArchive
    {
        Deferred<FS.FolderPath> Directories();

        Deferred<FS.FilePath> Enumerate();
    }
}