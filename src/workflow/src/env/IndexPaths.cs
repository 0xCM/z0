//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath IndexRoot()
            => TableRoot() + FS.folder(indices);

        FS.FilePath IndexFile(string id)
            => IndexRoot() + FS.file(id, FS.Idx);

        FS.FilePath IndexFile(string subject, string id)
            => IndexDir(subject) + FS.file(id, FS.Idx);

        FS.Files IndexFiles()
            => IndexRoot().Files(FS.Idx);
    }
}