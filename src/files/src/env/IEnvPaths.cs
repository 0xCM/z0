//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static EnvFolders;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using X = FS.Extensions;

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
            => SettingsRoot() + FS.file(id, X.Settings);

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

        FS.FolderPath ProcDumpRoot()
            => BinaryRoot() +  FS.folder(dumps);

        FS.FolderPath RepoArchiveDir()
            => BinaryRoot() + FS.folder(source);

        FS.Files RepoArchives()
            => RepoArchiveDir().Files(X.Zip);

        FS.FolderPath DumpFileRoot()
            => BinaryRoot() + FS.folder(dumps);

        FS.FilePath DumpFilePath(string id)
            => DumpFileRoot() + FS.file(id, X.Dmp);

        FS.FilePath DumpFilePath(PartId id)
            => DumpFilePath(id.Format());

        FS.FolderPath EventRoot()
            => DbRoot() + FS.folder(events);

        FS.FolderPath RefDataRoot()
            => DbRoot() + FS.folder(refdata);

        FS.FolderPath LogRoot()
            => DbRoot() + FS.folder(logs);

        FS.FolderPath CmdLogRoot()
            => LogRoot() + FS.folder(commands);

        FS.FilePath TmpFile(FS.FileName file)
            => TmpRoot() + file;

        FS.FilePath TmpFile(string name, FS.FileExt ext)
            => TmpRoot() + FS.file(name, ext);

        FS.FolderPath TmpDir<S>(S subject)
            => TmpRoot() + SubjectFolder(subject);
        FS.FilePath CmdLog(ScriptId id)
            => CmdLogRoot() + (id.IsDiscriminated
                ? FS.file(string.Format("{0}-{1}", id.Id, id.Token), X.Log)
                : FS.file(id.Format(), X.Log));

        FS.FolderPath ShowLogs()
            => LogRoot() + FS.folder("show");

        FS.FilePath ShowLog([Caller]string name = null, FS.FileExt? ext = null)
            => ShowLogs() + FS.file(name, ext ?? X.Log);

        FS.FilePath ProcDumpPath(Name process)
            => ProcDumpRoot() + FS.file(process.Format(), X.Dmp);

        FS.FolderPath DataSourceRoot()
            => DbRoot() + FS.folder("sources");

        FS.FilePath DataSource(FS.FileName file)
            => DataSourceRoot() + file;

        FS.FolderPath DataSourceDir(string id)
            => DataSourceRoot() + FS.folder(id);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        FS.FileName LegalFileName(OpIdentity id, FS.FileExt ext)
            => id.ToFileName(ext);

        FS.FileName LegalFileName(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);
    }
}