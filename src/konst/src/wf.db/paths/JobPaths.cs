//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath JobRoot()
            => DbRoot() + FS.folder(jobs);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder(queue);

        FS.FilePath JobPath(FS.FileName file)
            => JobQueue() + file;
    }
}