//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath LibRoot()
            => Env.Libs;

        FS.FolderPath LibDir(string name)
            => LibRoot() + FS.folder(name);

        FS.FolderPath LibDir(string name, string framework)
            => LibDir(name) + FS.folder(framework);

        FS.FolderPath LibDir(PartId part, string framework)
            => LibDir("z0." + part.Format()) + FS.folder(framework);

        FS.FilePath LibPath(PartId part, string framework)
            => LibDir("z0." + part.Format()) + FS.folder(framework) + FS.file("z0." + part.Format(), FS.Dll);

        FS.FilePath AppDataFile(FS.FileName file)
            => AppLogDir() + file;
    }
}