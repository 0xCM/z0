//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ArchiveFolderNames;

    public interface ILogPaths
    {
        /// <summary>
        /// The global application log root
        /// </summary>
        FS.FolderPath LogDir
            => EnvVars.Common.LogRoot;

        /// <summary>
        /// The global application log root
        /// </summary>
        FolderPath LogRoot
            => FolderPath.Define(LogDir.Name);

        FS.FolderPath AppLogRoot
            => FS.dir(text.format("{0}/applogs", LogRoot.Name));

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FolderName AppLogFolder
            => FolderName.Define(AppsFolder);

        // FS.FolderPath TestLogRootDir
        //     => LogDir + FS.folder(Test);

        // /// <summary>
        // /// The root test directory
        // /// </summary>
        // FolderPath TestLogRoot
        //     => FolderPath.Define(TestLogRootDir.Name);

        // FS.FilePath TestErrorLogPath
        //     => FS.path((TestLogRoot + FolderName.Define(ErrorLog) + FileName.define($"{AppName}.errors", FileExtensions.StatusLog)).Name);

        // FS.FilePath TestStatusLogPath
        //     => FS.path((TestLogRoot + FolderName.Define(StatusLog) + FileName.define($"{AppName}.stdout", FileExtensions.StatusLog)).Name);

        // FS.FilePath CaseLogPath
        //     => FS.path((TestLogRoot + FolderName.Define(StatusLog) + FileName.define($"{AppName}.cases", FileExtensions.Csv)).Name);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }
}