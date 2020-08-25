//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IShellPaths : IShellBase
    {
        FolderPath RuntimeRoot
            => FolderPath.Define(Part.RuntimeRoot);

        /// <summary>
        /// The global application log root
        /// </summary>
        FolderPath LogRoot
            => EnvVars.Common.LogRoot;

        FS.FolderPath AppLogRoot
            => FS.dir(text.format("{0}/apps/{1}/logs", LogRoot.Name, ShellName));

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FolderPath DevRoot
            => EnvVars.Common.DevRoot;

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FolderPath PubRoot
            => EnvVars.Common.PubRoot;

        /// <summary>
        /// The name of the folder that receives standard out stream data
        /// </summary>
        FolderName StatusLogFolder
            => FolderName.Define("status");

        /// <summary>
        /// The name of the folder that receives error stream data
        /// </summary>
        FolderName ErrorLogFolder
            => FolderName.Define("errors");

        /// <summary>
        /// The name of a folder that contains test result logs
        /// </summary>
        FolderName TestLogFolder
            => FolderName.Define("test");

        /// <summary>
        /// The name of a folder to which test data is emitted
        /// </summary>
        FolderName TestDataFolder
            => FolderName.Define("data");

        /// <summary>
        /// The name of the folder into which test results are deposited
        /// </summary>
        FolderName OutcomeFolder
            => FolderName.Define("results");

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FolderName AppLogFolder
            => FolderName.Define("apps");

        /// <summary>
        /// The name of the folder into which capture results are deposited
        /// </summary>
        FolderName CaptureFolder
            => FolderName.Define("capture");

        /// <summary>
        /// The name of the development source folder
        /// </summary>
        FolderName DevSrcFolder
            => FolderName.Define("src");

        /// <summary>
        /// The name of an application configuration file
        /// </summary>
        FileName ConfigFileName
            => FileName.Define("config.json");

        /// <summary>
        /// The name of a folder that contains one or more resource index files
        /// </summary>
        FolderName ResIndexFolder
            => FolderName.Define("index");

        /// <summary>
        /// The path to the directory that contains runtime configuration data
        /// </summary>
        FolderPath ConfigRoot
            => DevRoot + FolderName.Define(".settings");

        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FolderPath ResourceRoot
            => LogRoot + FolderName.Define("respack/content");

        /// <summary>
        /// The path to the resource index directory
        /// </summary>
        FolderPath ResIndexDir
            => ResourceRoot + ResIndexFolder;

        /// <summary>
        /// The executing application's part identifier
        /// </summary>
        PartId AppId
            => Part.ExecutingPart;

        /// <summary>
        /// The executing application's folder name
        /// </summary>
        FolderName AppFolder
            => FolderName.Define(ShellName);

        /// <summary>
        /// The root test directory
        /// </summary>
        FolderPath TestLogRoot
            => LogRoot + TestLogFolder;

        /// <summary>
        /// The build staging directory
        /// </summary>
        FolderPath BuildStage
            => LogRoot + FolderName.Define("builds");

        /// <summary>
        /// The directory into into which standard out stream emissions are deposited
        /// </summary>
        FolderPath AppStandardOut
            => RuntimeRoot + StatusLogFolder;

        /// <summary>
        /// The path to the global test error log directory
        /// </summary>
        FolderPath AppErrorOut
            => RuntimeRoot + ErrorLogFolder;

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName AppStandardOutName
            => FileName.Define($"{ShellName}.stdout", FileExtensions.StatusLog);

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName CaseLogName
            => FileName.Define($"{ShellName}.cases", FileExtensions.Csv);

        /// <summary>
        /// The executing application's error log filename
        /// </summary>
        FileName AppErrorOutName
            => FileName.Define($"{ShellName}.errors", FileExtensions.StatusLog);

        /// <summary>
        /// The executing application's data filename
        /// </summary>
        FileName AppDataFileName
            => FileName.Define($"{ShellName}", FileExtensions.Csv);

        /// <summary>
        /// The executing application's standard out log path
        /// </summary>
        FilePath AppStandardOutPath
            => AppStandardOut + AppStandardOutName;

        /// <summary>
        /// The executing application's error log path
        /// </summary>
        FilePath AppErrorOutPath
            => AppErrorOut + AppErrorOutName;

        /// <summary>
        /// The application-relative source code directory
        /// </summary>
        FolderPath AppDevRoot
            => (DevRoot +  DevSrcFolder) + AppFolder;

        /// <summary>
        /// The executing application's configuration file path
        /// </summary>
        FilePath AppConfigPath
            => AppDevRoot + ConfigFileName;

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FolderPath AppDataRoot
            => (LogRoot + AppLogFolder) + AppFolder;

        /// <summary>
        /// The application-relative capture directory
        /// </summary>
        FolderPath AppCaptureRoot
            => AppDataRoot + CaptureFolder;

        /// <summary>
        /// The <see cref='PartId.Machine'/> capture archive directory
        /// </summary>
        FolderPath MachineCaptureRoot
            =>  ResourceRoot + CaptureFolder;

        /// <summary>
        /// The root folder for test-specific data
        /// </summary>
        FolderPath TestDataRoot
            => TestLogRoot + TestDataFolder;

        /// <summary>
        /// The path to the global test error log directory
        /// </summary>
        FolderPath TestErrorOut
            => TestLogRoot + ErrorLogFolder;

        FilePath TestErrorPath
            => TestErrorOut + AppErrorOutName;

        FolderPath TestStandardOutDir
            => TestLogRoot + StatusLogFolder;

        FilePath TestStandardPath
            => TestStandardOutDir + AppStandardOutName;

        FilePath CaseLogPath
            => TestStandardOutDir + CaseLogName;

        /// <summary>
        /// Creates a provider rooted at the current root directory for another application
        /// </summary>
        /// <param name="dst">The target app id</param>
        IShellPaths ForApp(PartId dst)
            => new ShellPaths(dst, LogRoot);

        /// <summary>
        /// Defines a test-specific data folder
        /// </summary>
        /// <param name="test">The test host type</param>
        FolderPath TestDataDir(Type test)
            => TestDataRoot +  FolderName.Define((test ?? GetType()).Name);

        /// <summary>
        /// Defines a parametrically-identified test-specific data folder
        /// </summary>
        /// <typeparam name="T">The test host type</typeparam>
        FolderPath TestDataDir<T>()
            => TestDataDir(typeof(T));
    }
}