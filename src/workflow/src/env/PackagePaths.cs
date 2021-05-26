//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    public partial interface IEnvPaths
    {
       FS.FolderPath PackageRoot()
            => Env.Packages;

        FS.FolderPath PackageRoot(FS.FolderPath root)
            => root;

        FS.FolderPath Package(string id)
            => PackageRoot() + FS.folder(id);
    }
}