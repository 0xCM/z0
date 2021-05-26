//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    public partial interface IEnvPaths
    {
       FS.FolderName PartFolder(PartId part)
            => FS.folder(part.Format());

        FS.FolderPath PartDir(FS.FolderPath parent, PartId part)
            => parent + FS.folder(part.Format());
    }
}