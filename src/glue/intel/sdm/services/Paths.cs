//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static SdmModels;

    partial class IntelSdm
    {
        IProjectWs Project()
            => Ws.Project("intel.docs");

        FS.FolderPath Sources()
            => Project().Subdir("sources");

        FS.FilePath SdmSrcPath(byte vol)
            => Sources() + SdmSrcFile(vol);

        FS.FilePath SdmDstPath(byte vol)
            => ImportDir() + FS.file(string.Format("intel-sdm-vol{0}-{1}", vol, lined), FS.Txt);

        FS.FilePath TocImportPath()
            => ImportDir() + FS.file("sdm.toc", FS.Txt);

        FS.FilePath ProcessLog(string name)
            => LogDir() + FS.file(name, FS.Log);

        SortedSpan<FS.FilePath> TocPaths()
            => ImportDir().AllFiles.Where(f => IsTocPart(f)).Array().ToSortedSpan();

        FS.FilePath TocEntryTable()
            => ImportDir() + FS.file(TableId.identify<TocEntry>().Format(), FS.Csv);

        FS.FolderPath LogDir()
            => Project().Out() + FS.folder("intel.sdm.logs");

        FS.FolderPath ImportDir()
            => Project().Subdir("imports");

        FS.FolderPath SettingsDir()
            => Project().Subdir("settings");

        FS.FilePath CharMapPath()
            => SettingsDir() + FS.file("sdm.charmap", FS.Config);

        FS.FilePath UnmappedCharLog()
            => LogDir() + FS.file("unmapped", FS.Log);

        FS.FilePath SplitSpecs()
            => SettingsDir() + FS.file("sdm.splits", FS.Csv);

        FS.FileName SdmSrcFile(byte vol)
            => FS.file(string.Format("intel-sdm-vol{0}", vol), FS.Txt);

        FS.FilePath SdmSrcPath()
            => Sources() + FS.file("intel-sdm", FS.Txt);
    }
}