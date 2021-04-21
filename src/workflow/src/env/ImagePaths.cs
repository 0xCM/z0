//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;
    using static FS;

    partial interface IEnvPaths
    {
        FS.FolderPath ImageArchiveRoot()
            => DataRoot() + FS.folder(images);
    }
}