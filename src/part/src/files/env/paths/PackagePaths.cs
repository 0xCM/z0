//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial interface IEnvPaths
    {
        FS.FolderPath PackageRoot()
            => Env.Packages;

        FS.FolderPath Package(string id)
            => PackageRoot() + FS.folder(id);
    }
}