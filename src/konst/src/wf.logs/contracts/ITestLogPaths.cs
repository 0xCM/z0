//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ArchiveFolders;

    public interface ITestLogPaths : IFileArchive
    {
        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        FS.FolderPath TestLogRoot
            => Root + FS.folder("logs");

        FS.FilePath BenchLogPath
            => TestLogRoot + FS.folder(StatusFolder) + FS.file($"{AppName}.bench", FileExtensions.Csv);
    }
}