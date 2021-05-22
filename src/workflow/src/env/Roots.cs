//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    public partial interface IEnvPaths
    {
        FS.FolderPath ZDev()
            => Env.ZDev;

        FS.FolderPath DataRoot()
            => Env.DataRoot;

        FS.FolderPath DataRoot(FS.FolderPath root)
            => root;

        FS.FolderPath DbRoot()
            => Env.Db;

        FS.FolderPath DbRoot(FS.FolderPath root)
            => root;

        FS.FolderPath PackageRoot()
            => Env.Packages;

        FS.FolderPath PackageRoot(FS.FolderPath root)
            => root;

        FS.FolderPath DevRoot()
            => Env.DevRoot;

        FS.FolderPath DevRoot(FS.FolderPath root)
            => root;

        FS.FolderPath ArchiveRoot()
            => Env.Archives;

        FS.FolderPath ArchiveRoot(FS.FolderPath root)
            => root;

        FS.FolderPath TmpRoot()
            => Env.Tmp.Value + FS.folder(tmp);

        FS.FolderPath RuntimeRoot()
            => Env.ZBin;

        FS.FolderPath SymbolRoot()
            => Env.SymCacheRoot;

        FS.FolderPath NtSymbolDir()
            => Env.DefaultSymbolCache;

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

        FS.FolderPath ReportRoot()
            => DbRoot() + FS.folder(reports);

        FS.FolderPath SettingsRoot()
            => DbRoot() + FS.folder(settings);

        FS.FolderPath ControlScripts()
            => ControlRoot() + FS.folder(".cmd");

        FS.FolderName PartFolder(PartId part)
            => FS.folder(part.Format());

        FS.FolderPath PartDir(FS.FolderPath parent, PartId part)
            => parent + FS.folder(part.Format());

        FS.FileName HostFile(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", host.Part.Format(), host.Name), ext);
    }
}