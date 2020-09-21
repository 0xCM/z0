//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static GlobalFolderNames;
    using FN = GlobalFolderNames;

    public interface IShellPaths
    {
        IPartCaptureArchive PartCaptureArchive
            => Archives.capture(FS.dir(LogRoot.Name) + FS.folder(FN.Capture));

        IPartCaptureArchive CaptureArchive()
            => Archives.capture(FS.dir(LogRoot.Name) + FS.folder(Capture) + FS.folder(ArtifactFolder));

        IHostCaptureArchive CaptureArchive(ApiHostUri host)
            => HostCaptureArchive.create(CaptureArchive().ArchiveRoot, host);

        string ShellName
            => Assembly.GetEntryAssembly().GetSimpleName();

        FolderPath ShellExeDir
            => FolderPath.Define(Part.ShellExeDir);

        /// <summary>
        /// The global application log root
        /// </summary>
        FolderPath LogRoot
            => EnvVars.Common.LogRoot;

        FS.FolderPath DbRoot
            => FS.dir(LogRoot.Name) + FS.folder("db");

        FS.FolderPath AppLogRoot
            => FS.dir(text.format("{0}/apps/{1}/logs", LogRoot.Name, ShellName));

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FolderPath DevRoot
            => EnvVars.Common.DevRoot;

        /// <summary>
        /// The name of the folder that receives standard out stream data
        /// </summary>
        FolderName StatusLogFolder
            => FolderName.Define(StatusLog);

        /// <summary>
        /// The name of the folder that receives error stream data
        /// </summary>
        FolderName ErrorLogFolder
            => FolderName.Define(ErrorLog);

        /// <summary>
        /// The name of a folder that contains test result logs
        /// </summary>
        FolderName TestLogFolder
            => FolderName.Define(Test);

        /// <summary>
        /// The name of a folder to which test data is emitted
        /// </summary>
        FolderName TestDataFolder
            => FolderName.Define("data");

        /// <summary>
        /// The name of the folder into which test results are deposited
        /// </summary>
        FolderName OutcomeFolder
            => FolderName.Define(Results);

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FolderName AppLogFolder
            => FolderName.Define(AppsFolder);

        /// <summary>
        /// The name of the folder into which capture results are deposited
        /// </summary>
        FolderName CaptureFolder
            => FolderName.Define(Capture);

        /// <summary>
        /// The name of the development source folder
        /// </summary>
        FolderName DevSrcFolder
            => FolderName.Define("src");

        /// <summary>
        /// The name of an application configuration file
        /// </summary>
        FileName ConfigFileName
            => FileName.define("config.json");

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
            => LogRoot + FolderName.Define(RespackContent);

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
        /// The directory into into which standard out stream emissions are deposited
        /// </summary>
        FolderPath AppStatusLogDir
            => ShellExeDir + StatusLogFolder;

        /// <summary>
        /// The path to the global test error log directory
        /// </summary>
        FolderPath AppErrorLogDir
            => ShellExeDir + ErrorLogFolder;

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName AppStatusLogName
            => FileName.define($"{ShellName}.stdout", FileExtensions.StatusLog);

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName CaseLogName
            => FileName.define($"{ShellName}.cases", FileExtensions.Csv);

        /// <summary>
        /// The executing application's error log filename
        /// </summary>
        FileName AppErrorLogName
            => FileName.define($"{ShellName}.errors", FileExtensions.StatusLog);

        /// <summary>
        /// The executing application's standard out log path
        /// </summary>
        FilePath AppStatusLogPath
            => AppStatusLogDir + AppStatusLogName;

        /// <summary>
        /// The executing application's error log path
        /// </summary>
        FilePath AppErrorLogPath
            => AppErrorLogDir + AppErrorLogName;

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
        /// The root folder for test-specific data
        /// </summary>
        FolderPath TestDataRoot
            => TestLogRoot + TestDataFolder;

        FilePath TestErrorPath
            => TestLogRoot + ErrorLogFolder + AppErrorLogName;

        FilePath TestStatusPath
            => TestLogRoot + StatusLogFolder + AppStatusLogName;

        FilePath CaseLogPath
            => TestLogRoot + StatusLogFolder + CaseLogName;

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