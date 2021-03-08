//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath AppLogRoot()
            => LogRoot() + FS.folder(apps);

        FS.FolderPath AppDataFolder()
            => AppLogRoot() + FS.folder(AppName);

        FS.FilePath AppDataFile(FS.FileName file)
            => AppDataFolder() + file;

        FS.FilePath AppLog(string id)
            =>  AppLogRoot() + FS.file(id, Log);

        FS.FilePath AppLog(string id, FS.FileExt ext)
            => AppLogRoot() + FS.file(id,ext);
    }
}