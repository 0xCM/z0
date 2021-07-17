//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath JobRoot()
            => DbRoot() + FS.folder(jobs);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder(queue);
    }
}