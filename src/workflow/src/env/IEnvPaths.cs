//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static EnvFolders;


    public partial interface IEnvPaths
    {
        Env Env {get;}

        FS.FolderPath SettingsRoot()
            => DbRoot() + FS.folder(settings);

        FS.FolderPath ControlScripts()
            => ControlRoot() + FS.folder(".cmd");

        FS.FilePath ControlScript(FS.FileName src)
            => ControlScripts() + src;

        FS.FolderPath Package(string id)
            => PackageRoot() + FS.folder(id);

        FS.FolderName SubjectFolder<S>(S src)
            => FS.folder(src.ToString().ToLowerInvariant());

        FS.FilePath SettingsPath(string id)
            => SettingsRoot() + FS.file(id, FS.Settings);

        FS.FolderPath DevRoot(string id)
            => DevRoot() + FS.folder(id);

        FS.FolderPath ZRoot()
            => DevRoot(z0);

        FS.FolderPath PartDir(string id)
            => ZRoot() + FS.folder(src) + FS.folder(id);

        FS.FolderPath PartDir(PartId id)
            => ZRoot() + FS.folder(src) + FS.folder(id.Componentize().Join('.'));

        FS.FilePath SourceFile(PartId id, FS.FileName name)
            => PartDir(id) + FS.folder(src) + name;

        FS.FolderPath SourceBuildRoot()
            => ZRoot() + FS.folder(build);

        FS.FolderPath BinaryRoot()
            => DbRoot() + FS.folder(bin);

        FS.FolderPath RepoArchiveDir()
            => BinaryRoot() + FS.folder(source);

        FS.Files RepoArchives()
            => RepoArchiveDir().Files(FS.Zip);

        FS.FolderPath EventRoot()
            => DbRoot() + FS.folder(events);

        FS.FolderPath RefDataRoot()
            => DbRoot() + FS.folder(refdata);

        FS.FilePath TmpFile(FS.FileName file)
            => TmpRoot() + file;

        FS.FilePath TmpFile(string name, FS.FileExt ext)
            => TmpRoot() + FS.file(name, ext);

        FS.FolderPath TmpDir<S>(S subject)
            => TmpRoot() + SubjectFolder(subject);

        FS.FolderPath DataSourceRoot()
            => DbRoot() + FS.folder("sources");

        FS.FilePath DataSource(FS.FileName file)
            => DataSourceRoot() + file;

        FS.FolderPath DataSourceDir(string id)
            => DataSourceRoot() + FS.folder(id);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }
}