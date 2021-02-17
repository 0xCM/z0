//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static ArchiveFolders;

    [Free]
    public interface IWfAppPaths : IFileArchive
    {
        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FS.FolderName AppLogFolder
            => FS.folder(AppsFolder);

        FS.FolderPath DbRoot
            => WfEnv.dbRoot();

        ITestLogPaths TestPaths
            => new TestLogPaths(Root + FS.folder("logs") + FS.folder("tests"));

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataDir
            => (Root + FS.folder(AppsFolder)) + FS.folder(AppName);

        /// <summary>
        /// The name of an application configuration file
        /// </summary>
        FS.FileName ConfigFileName
            => FS.file(AppName, JsonConfig);

        /// <summary>
        /// The executing application's configuration file path
        /// </summary>
        FS.FilePath AppConfigPath
            => Root + FS.folder("config") + ConfigFileName;

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
        /// The executing application's data directory
        /// </summary>
        FS.FolderPath AppDataRoot
            => (Root + AppLogFolder) + AppFolder;

        /// <summary>
        /// The application-relative capture directory
        /// </summary>
        FS.FolderPath AppCaptureRoot
            => AppDataRoot + FS.folder(CaptureFolder);

        /// <summary>
        /// Creates a path provider for the controlling application
        /// </summary>
        IWfAppPaths ForApp()
            => WfShell.paths();
    }
}