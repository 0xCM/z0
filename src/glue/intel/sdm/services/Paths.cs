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

        public FS.FolderPath IntelSources()
            => Ws.Sources().Datasets("intel.pubs");

        public FS.FilePath SdmSrcPath(byte vol)
            => IntelSources() + SdmSrcFile(vol);

        public FS.Files ImportPaths()
            => ImportDir().AllFiles;

        public FS.FilePath SdmDstPath(byte vol)
            => ImportDir() + FS.file(string.Format("intel-sdm-vol{0}-{1}", vol, lined), FS.Txt);

        public FS.FilePath TocImportPath()
            => ImportDir() + FS.file("sdm.toc", FS.Txt);

        public FS.FilePath ProcessLog(string name)
            => LogDir() + FS.file(name, FS.Log);

        public SortedSpan<FS.FilePath> TocPaths()
            => ImportDir().AllFiles.Where(f => IsTocPart(f)).Array().ToSortedSpan();

        public FS.FilePath TocEntryTable()
            => ImportDir() + FS.file(TableId.identify<TocEntry>().Format(), FS.Csv);

        FS.FolderPath LogDir()
            => Project().Out() + FS.folder("intel.sdm.logs");

        IWorkspace Imports()
            => Ws.Imports();

        FS.FolderPath ImportDir()
            => Project().Subdir("imports");

        FS.FolderPath SettingsDir()
            => Project().Subdir("settings");

        FS.FilePath CharMapPath()
            => SettingsDir() + FS.file("sdm.charmap", FS.Config);

        FS.FilePath UnmappedCharLog()
            => LogDir() + FS.file("unmapped", FS.Log);

        FS.FilePath SplitSpecs()
            => Ws.Sources().Settings("sdm.splits", FS.Csv);

        FS.FileName SdmUnicodeFile()
            => FS.file("intel-sdm-unicode", FS.Txt);

        FS.FileName SdmSrcFile(byte vol)
            => FS.file(string.Format("intel-sdm-vol{0}", vol), FS.Txt);

        FS.FilePath SdmSrcPath()
            => IntelSources() + FS.file("intel-sdm", FS.Txt);

        FS.FilePath SdmImportPath()
            => ImportDir() + FS.file(string.Format("intel-sdm-{0}", lined), FS.Txt);
    }
}