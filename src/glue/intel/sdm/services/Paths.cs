//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class IntelSdmProcessor
    {
        FS.FilePath CharMapPath()
            => SourceRoot() + FS.file(charmap, FS.Config);

        FS.FilePath SplitSpecs()
            => SourceRoot() + FS.file(splits, FS.Csv);

        FS.FilePath ProcessLog(string name)
            => LogRoot() + FS.file(name, FS.Log);

        FS.FilePath LinedSdmPath()
            => ImportRoot() + FS.file(string.Format("{0}.{1}", dataset, lined), FS.Txt);

        FS.FilePath SourceDocPath()
            => Workspace.DataSource(dataset) + FS.file(dataset, FS.Txt);

        FS.FolderPath ImportRoot()
            => Workspace.ImportDir(dataset);

        FS.FolderPath LogRoot()
            => Workspace.ImportDir(datasetlogs);

        FS.FolderPath SourceRoot()
            => Workspace.DataSource(dataset);

        FS.FilePath ImportPath(string id, FS.FileExt ext)
            => ImportRoot() + FS.file(string.Format("{0}.{1}", dataset, id), ext);

        FS.FilePath CombinedTocPath()
            => ImportPath(toc, FS.Txt);

        SortedSpan<FS.FilePath> IndividualTocPaths()
            => ImportRoot().AllFiles.Where(f => IsTocPart(f)).Array().ToSortedSpan();
    }
}