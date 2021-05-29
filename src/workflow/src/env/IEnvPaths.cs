//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static EnvFolders;

    partial interface IEnvPaths
    {
        EnvData Env {get;}

        FS.FilePath ControlScript(FS.FileName src)
            => ControlScripts() + src;

        FS.FolderName SubjectFolder<S>(S src)
            => FS.folder(src.ToString().ToLowerInvariant());

        FS.FilePath SettingsPath(string id)
            => SettingsRoot() + FS.file(id, FS.Settings);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }
}