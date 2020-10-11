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
            => FS.dir(EnvVars.Common.LogRoot.Name);

        /// <summary>
        /// The global application log root
        /// </summary>
        FolderPath LogRoot
            => EnvVars.Common.LogRoot;

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
        /// The directory into into which standard out stream emissions are deposited
        /// </summary>
        FS.FolderPath AppStatusLogDir
            => AppLogRoot + FS.folder(StatusLog);

        /// <summary>
        /// The path to the global test error log directory
        /// </summary>
        FS.FolderPath AppErrorLogDir
            => AppLogRoot + FS.folder(ErrorLog);

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

        FilePath TestErrorPath
            => TestLogRoot + ErrorLogFolder + AppErrorLogName;

        FilePath TestStatusPath
            => TestLogRoot + StatusLogFolder + AppStatusLogName;

        FilePath CaseLogPath
            => TestLogRoot + StatusLogFolder + CaseLogName;

        string ShellName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }
}