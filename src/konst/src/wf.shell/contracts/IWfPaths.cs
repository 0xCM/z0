//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static ArchiveFolderNames;

    [Free]
    public interface IWfPaths : IDbPaths
    {
        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FS.FolderName AppLogFolder
            => FS.folder(AppsFolder);

        ITestRunPaths TestPaths
            => TestRunPaths.define(DbRoot + FS.folder("tests"));

        FS.FolderPath CodeGenRoot
            => FS.dir(@"j:\dev\projects\z0.generated");

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataDir
            => (Root + FS.folder(AppsFolder)) + FS.folder(AppName);

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FS.FolderPath DevRoot
            => EnvVars.Common.DevRoot;

        FS.FolderPath SortedCaseLogRoot()
            => Root + FS.folder("tests") + FS.folder("sorted");

        FS.FilePath SortedCaseLogPath()
            => SortedCaseLogRoot() + FS.file(AppName,  FileExtensions.Csv);

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
        /// The path to the root application resource directory
        /// </summary>
        FS.FolderPath ResourceRoot
            => Root + FS.folder(RespackContent);

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
        /// The executing application's folder name
        /// </summary>
        FS.FolderName AppDevFolder
            => FS.folder(AppName.Remove("z0."));

        /// <summary>
        /// The application-relative source code directory
        /// </summary>
        FS.FolderPath AppDevRoot
            => (DevRoot +  DevSrcFolder) + AppDevFolder;

        /// <summary>
        /// The executing application's configuration file path
        /// </summary>
        FS.FilePath AppConfigPath
            => AppDevRoot + ConfigFileName;

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataRoot
            => (Root + AppLogFolder) + AppFolder;

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