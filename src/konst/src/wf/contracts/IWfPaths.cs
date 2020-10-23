//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ArchiveFolderNames;

    public interface IWfPaths : ILogPaths
    {
        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataDir
            => (LogDir + FS.folder(AppsFolder)) + FS.folder(AppName);

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
            => FolderName.Define(AppName);

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
            => AppDataRoot + FolderName.Define(Capture);

        /// <summary>
        /// Creates a provider rooted at the current root directory for another application
        /// </summary>
        /// <param name="dst">The target app id</param>
        IWfPaths ForApp()
            => WfShell.paths(LogDir);
    }
}