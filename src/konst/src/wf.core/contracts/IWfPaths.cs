//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ArchiveFolderNames;

    using FN = ArchiveFolderNames;

    public interface IWfPaths : ILogPaths
    {
        ICaptureArchive PartCaptureArchive
            => Archives.capture(FS.dir(LogRoot.Name) + FS.folder(FN.Capture));

        ICaptureArchive CaptureArchive()
            => Archives.capture(FS.dir(LogRoot.Name) + FS.folder(Capture) + FS.folder(ArtifactFolder));

        IHostCaptureArchive CaptureArchive(ApiHostUri host)
            => HostCaptureArchive.create(CaptureArchive().ArchiveRoot, host);

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataDir
            => (LogDir + FS.folder(AppsFolder)) + FS.folder(ShellName);

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FolderPath DevRoot
            => EnvVars.Common.DevRoot;

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
        FS.FolderPath ResIndexDir
            => FS.dir(ResourceRoot.Name) + FS.folder("index");

        /// <summary>
        /// The executing application's folder name
        /// </summary>
        FolderName AppFolder
            => FolderName.Define(ShellName);

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

        /// <summary>
        /// The name of the entry assembly
        /// </summary>
        string AppName
            => Part.AppName;

        /// <summary>
        /// Creates a provider rooted at the current root directory for another application
        /// </summary>
        /// <param name="dst">The target app id</param>
        IWfPaths ForApp()
            => new WfPaths(LogDir);

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