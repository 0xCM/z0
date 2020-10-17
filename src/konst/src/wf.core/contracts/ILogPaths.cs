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
            => FolderPath.Define(EnvVars.Common.LogRoot.Name);

        FS.FolderPath AppLogRoot
            => FS.dir(text.format("{0}/applogs", LogRoot.Name));

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
        /// The name of the runtime log folder
        /// </summary>
        FolderName AppLogFolder
            => FolderName.Define(AppsFolder);

        /// <summary>
        /// The root test directory
        /// </summary>
        FolderPath TestLogRoot
            => LogRoot + TestLogFolder;

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName AppStatusLogName
            => FileName.define($"{AppName}.stdout", FileExtensions.StatusLog);

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName CaseLogName
            => FileName.define($"{AppName}.cases", FileExtensions.Csv);

        /// <summary>
        /// The executing application's error log filename
        /// </summary>
        FileName AppErrorLogName
            => FileName.define($"{AppName}.errors", FileExtensions.StatusLog);

        FilePath TestErrorPath
            => TestLogRoot + ErrorLogFolder + AppErrorLogName;

        FilePath TestStatusPath
            => TestLogRoot + StatusLogFolder + AppStatusLogName;

        FilePath CaseLogPath
            => TestLogRoot + StatusLogFolder + CaseLogName;

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }
}