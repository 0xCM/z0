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

        FS.FolderPath DbRoot()
            => Env.Db;

        FS.FolderPath PackageRoot()
            => Env.Packages;

        FS.FolderPath DevRoot()
            => Env.DevRoot;

        FS.FolderPath ArchiveRoot()
            => Env.Archives;

        FS.FolderPath TmpRoot()
            => Env.Tmp.Value + FS.folder(tmp);

        FS.FolderPath ControlRoot()
            => Env.Control;

        FS.FolderPath RuntimeRoot()
            => Env.ZBin;

        FS.FolderPath SymbolRoot()
            => Env.SymCacheRoot;

        FS.FolderPath NtSymbolDir()
            => Env.DefaultSymbolCache;

        FS.FolderName PartFolder(PartId part)
            => FS.folder(part.Format());

        FS.FileName HostFile(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", host.Part.Format(), host.Name), ext);
    }
}