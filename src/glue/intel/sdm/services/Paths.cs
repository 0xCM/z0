//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class IntelSdmProcessor
    {
        public ReadOnlySpan<FS.FilePath> SdmUnicodeSources()
            => (RefDocRoot()+ FS.folder(txt)).Files(FS.Txt).Where(f => f.Contains(unicode));

        FS.FolderPath ImportRoot()
            => Workspace.ImportDir(dataset);

        FS.FilePath CharMapPath()
            => Workspace.Settings("sdm.charmap", FS.Config);

        FS.FilePath UnmappedCharLog()
            => Workspace.EtlLog(unmapped);

        FS.FilePath SplitSpecs()
            => Workspace.Settings("sdm.splits", FS.Csv);

        FS.FilePath ProcessLog(string name)
            => LogRoot() + FS.file(name, FS.Log);

        FS.FileName SdmUnicodeFile()
            => FS.file("intel-sdm-unicode", FS.Txt);

        FS.FileName SdmUnicodeFile(byte vol)
            => FS.file(string.Format("intel-sdm-vol{0}-{1}", vol, unicode), FS.Txt);

        FS.FolderPath RefDocRoot()
            => Workspace.RefDocs();

        FS.FolderPath RefDocRoot(string id)
            => RefDocRoot() + FS.folder(id);

        FS.FilePath SdmUnicodePath()
            => RefDocRoot(txt)  + SdmUnicodeFile();

        FS.FilePath SdmUnicodePath(byte vol)
            => RefDocRoot(txt)  + SdmUnicodeFile(vol);

        FS.FilePath LinedSdmPath()
            => ImportRoot() + FS.file(string.Format("intel-sdm-{0}", lined), FS.Txt);

        FS.FilePath LinedSdmPath(byte vol)
            => ImportRoot() + FS.file(string.Format("intel-sdm-vol{0}-{1}", vol, lined), FS.Txt);

        FS.FolderPath LogRoot()
            => Workspace.ImportDir(datasetlogs);

        FS.FilePath CombinedTocPath()
            => Workspace.ImportDir("sdm") + FS.file("sdm.toc", FS.Txt);

        SortedSpan<FS.FilePath> IndividualTocPaths()
            => ImportRoot().AllFiles.Where(f => IsTocPart(f)).Array().ToSortedSpan();
    }
}