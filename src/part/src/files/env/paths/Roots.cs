//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath DataRoot()
            => Env.DataRoot;

        FS.FolderPath DevWs()
            => Env.DevWs;

        FS.FolderPath AsmWs()
            => Env.AsmWs;

        FS.FolderPath ToolWs()
            => Env.ToolWs;

        FS.FolderPath DbRoot()
            => Env.Db;

        FS.FolderPath DbRoot(FS.FolderPath root)
            => root;

        FS.FolderPath RuntimeRoot()
            => Env.ZBin;

        FS.FolderPath BinaryRoot()
            => DbRoot() + FS.folder(bin);

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

        FS.FileName HostFile(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", host.Part.Format(), host.HostName), ext);
    }
}