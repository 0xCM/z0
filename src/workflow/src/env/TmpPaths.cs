//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath TmpRoot()
            => Env.Tmp.Value + FS.folder(tmp);

        FS.FilePath TmpFile(FS.FileName file)
            => TmpRoot() + file;

        FS.FilePath TmpFile(string name, FS.FileExt ext)
            => TmpRoot() + FS.file(name, ext);

        FS.FolderPath TmpDir<S>(S subject)
            => TmpRoot() + SubjectFolder(subject);
    }
}