//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ArchiveFolderNames;

    public interface ITestRunPaths : IFileArchive
    {
        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        FS.FolderPath TestLogRoot
            => Root + FS.folder("logs");

        FS.FolderPath SortedCaseLogRoot()
            => TestLogRoot;

        FS.FilePath SortedCaseLogPath()
            => SortedCaseLogRoot() + FS.file(AppName, FS.ext("sorted","csv"));

        /// <summary>
        /// The root folder for test-specific data
        /// </summary>
        FS.FolderPath DataRoot
            => TestLogRoot + FS.folder("data");

        FS.FilePath ErrorLogPath
            => TestLogRoot + FS.folder(ErrorLog) + FS.file($"{AppName}.errors", FileExtensions.Log);

        FS.FilePath StatusLogPath
            => TestLogRoot + FS.folder(StatusLog) + FS.file($"{AppName}.stdout", FileExtensions.Log);

        FS.FilePath CaseLogPath
            => TestLogRoot + FS.folder(StatusLog) + FS.file($"{AppName}.cases", FileExtensions.Csv);

        /// <summary>
        /// Defines a test-specific data folder
        /// </summary>
        /// <param name="test">The test host type</param>
        FS.FolderPath TestDataDir(Type test)
            => DataRoot + FS.folder(test.Name);

        /// <summary>
        /// Defines a parametrically-identified test-specific data folder
        /// </summary>
        /// <typeparam name="T">The test host type</typeparam>
        FS.FolderPath TestDataDir<T>()
            => TestDataDir(typeof(T));
    }
}