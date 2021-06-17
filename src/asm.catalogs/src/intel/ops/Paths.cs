//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class IntelSdmProcessor
    {
       FS.FilePath SdmSplitSpecs()
            => Archive.Root + FS.file("splits", FS.Csv);

        FS.FilePath SdmRefPath()
            => RefDocPath("sdm");

        FS.FolderPath ProcessLogs()
            => Archive.Root + FS.folder("logs");

        FS.FilePath ProcessLog(string name)
            => ProcessLogs() + FS.file(name,FS.Log);

        FS.FilePath LinedSdmPath()
            => DocExtractPath("sdm-lined", FS.Txt);

        FS.FilePath RefDocPath(string id)
            => Archive.RefDoc(id, FS.Txt);

        FS.FolderPath SdmExtractRoot()
            => Archive.DocExtractDir("sdm");

        FS.FilePath DocExtractPath(string id, FS.FileExt ext)
            => SdmExtractRoot() + FS.file(string.Format("sdm.{0}", id), ext);

        FS.FilePath CombinedTocPath()
            => DocExtractPath("TOC",FS.Txt);
    }
}