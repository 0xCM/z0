//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static CoreFolderNames;

    public interface ITestLogPaths : ILogPaths
    {
        /// <summary>
        /// The name of a folder to which test data is emitted
        /// </summary>
        FS.FolderName TestDataFolder
            => FS.folder("data");

        /// <summary>
        /// The root folder for test-specific data
        /// </summary>
        FS.FolderPath TestDataRoot
            => TestLogRootDir + TestDataFolder;

        FS.FolderPath TestLogRootDir
            => RuntimeData + FS.folder(Test);

        /// <summary>
        /// The root test directory
        /// </summary>
        FolderPath TestLogRoot
            => FolderPath.Define(TestLogRootDir.Name);

        FS.FilePath TestErrorLogPath
            => FS.path((TestLogRoot + FolderName.Define(ErrorLog) + FileName.define($"{AppName}.errors", FileExtensions.StatusLog)).Name);

        FS.FilePath TestStatusLogPath
            => FS.path((TestLogRoot + FolderName.Define(StatusLog) + FileName.define($"{AppName}.stdout", FileExtensions.StatusLog)).Name);

        FS.FilePath CaseLogPath
            => FS.path((TestLogRoot + FolderName.Define(StatusLog) + FileName.define($"{AppName}.cases", FileExtensions.Csv)).Name);

        /// <summary>
        /// Defines a test-specific data folder
        /// </summary>
        /// <param name="test">The test host type</param>
        FS.FolderPath TestDataDir(Type test)
            => TestDataRoot +  FS.folder((test ?? GetType()).Name);

        /// <summary>
        /// Defines a parametrically-identified test-specific data folder
        /// </summary>
        /// <typeparam name="T">The test host type</typeparam>
        FS.FolderPath TestDataDir<T>()
            => TestDataDir(typeof(T));
    }
}