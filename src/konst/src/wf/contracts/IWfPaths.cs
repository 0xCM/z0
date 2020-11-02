//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static ArchiveFolderNames;

    public interface IWfPaths : ILogPaths
    {
        /// <summary>
        /// The workflow's database root
        /// </summary>
        FS.FolderPath DbRoot {get;}

        FS.FolderPath CaptureRoot
            => DbRoot + FS.folder("capture");

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataDir
            => (RuntimeData + FS.folder(AppsFolder)) + FS.folder(AppName);

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FS.FolderPath DevRoot
            => EnvVars.Common.DevRoot;

        /// <summary>
        /// The name of the folder into which test results are deposited
        /// </summary>
        FS.FolderName OutcomeFolder
            => FS.folder(Results);

        /// <summary>
        /// The name of the development source folder
        /// </summary>
        FS.FolderName DevSrcFolder
            => FS.folder("src");

        /// <summary>
        /// The name of an application configuration file
        /// </summary>
        FS.FileName ConfigFileName
            => FS.file("config.json");

        /// <summary>
        /// The path to the directory that contains runtime configuration data
        /// </summary>
        FS.FolderPath ConfigRoot
            => DevRoot + FS.folder(".settings");

        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FS.FolderPath ResourceRoot
            => RuntimeLogs + FS.folder(RespackContent);

        /// <summary>
        /// The path to the resource index directory
        /// </summary>
        FS.FolderPath ResIndexDir
            => FS.dir(ResourceRoot.Name) + FS.folder("index");

        /// <summary>
        /// The executing application's folder name
        /// </summary>
        FS.FolderName AppFolder
            => FS.folder(AppName);

        /// <summary>
        /// The application-relative source code directory
        /// </summary>
        FS.FolderPath AppDevRoot
            => (DevRoot +  DevSrcFolder) + AppFolder;

        /// <summary>
        /// The executing application's configuration file path
        /// </summary>
        FS.FilePath AppConfigPath
            => AppDevRoot + ConfigFileName;

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataRoot
            => (RuntimeLogs + AppLogFolder) + AppFolder;

        /// <summary>
        /// The application-relative capture directory
        /// </summary>
        FS.FolderPath AppCaptureRoot
            => AppDataRoot + FS.folder(Capture);

        /// <summary>
        /// Creates a path provider for the controlling application
        /// </summary>
        IWfPaths ForApp()
            => WfShell.paths();
    }
}