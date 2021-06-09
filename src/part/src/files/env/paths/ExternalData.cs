//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
       FS.FolderPath ExternalDataRoot()
            => DbRoot() + FS.folder(external);

        FS.FilePath ExternalDataPath(FS.FileName file)
            => ExternalDataRoot() + file;

        FS.FolderPath ExternalDataDir(string id)
            => ExternalDataRoot() + FS.folder(id);
    }
}