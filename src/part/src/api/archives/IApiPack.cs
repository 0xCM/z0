//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    public interface IApiPack : IFileArchive
    {
        Timestamp Timestamp {get;}

        ApiExtractSettings ExtractSettings {get;}

        // FS.FolderPath IFileArchive.Root
        //     => Archive().Root;

        ApiPackArchive Archive()
            => ApiPackArchive.create(Root);

        FS.FilePath ProcDumpPath(Process process, Timestamp ts)
            => Archive().ProcDumpPath(process, ts);

        FS.FolderPath HexPackRoot()
            => Archive().HexPackRoot();

        FS.FolderPath ContextRoot()
            => Archive().ContextRoot();

        FS.Files AsmCapturePaths(PartId part)
            => Archive().AsmCapturePaths(part);
    }
}