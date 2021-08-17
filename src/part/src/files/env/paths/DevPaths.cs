//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath DevRoot(string id)
            => DevRoot() + FS.folder(id);

        FS.FolderPath ZSrc()
            => ZRoot() + FS.folder(src);

        FS.FolderPath ZSrc(string project)
            => ZSrc() + FS.folder(project);

        FS.FolderPath ZSrc(string project, string subfolder)
            => ZSrc(project) + FS.folder(subfolder);

        FS.FolderPath PartSrcDir(string id)
            => ZRoot() + FS.folder(src) + FS.folder(id);

        FS.FolderPath PartSrcDir(PartId id)
            => ZRoot() + FS.folder(src) + FS.folder(id.Format());

        FS.FilePath PartSrcFile(PartId id, FS.FileName name)
            => PartSrcDir(id) + FS.folder(src) + name;
    }
}