//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface TAppPaths : ITextual
    {
        /// <summary>
        /// The name of the folder that receives standard out stream data
        /// </summary>
        FolderName StandardOutFolder 
            => FolderName.Define("stdout");

        /// <summary>
        /// The name of the folder that receives error stream data
        /// </summary>
        FolderName ErrorOutFolder 
            => FolderName.Define("errors");

        /// <summary>
        /// The name of a data folder
        /// </summary>
        FolderName DataFolder
            => FolderName.Define("data");

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
        /// The name of an application resource folder
        /// </summary>
        FolderName ResoureFolder 
            => FolderName.Define("res");

        /// <summary>
        /// The name of an application resource folder
        /// </summary>
        FolderName ExportFolder
            => FolderName.Define("exports");

        /// <summary>
        /// The name of the folder into which test results are deposited
        /// </summary>
        FolderName TestResultFolder 
            => FolderName.Define("results");

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FolderName RuntimeLogFolder
            => FolderName.Define("apps");

        /// <summary>
        /// The name of the folder into which capture results are deposited
        /// </summary>
        FolderName CaptureFolder 
            => FolderName.Define("capture");        

        /// <summary>
        /// The name of the development source folder
        /// </summary>
        FolderName SrcFolder 
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
        /// The global application log root
        /// </summary>
        FolderPath LogRoot 
            => Env.Current.LogDir;

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FolderPath DevRoot 
            => Env.Current.DevDir;

        /// <summary>
        /// The path to the root data directory
        /// </summary>
        FolderPath TrackedDataRoot 
            => DevRoot + DataFolder;

        /// <summary>
        /// The path to the directory that contains runtime configuration data
        /// </summary>
        FolderPath ConfigRoot
            => DevRoot + FolderName.Define(".settings");

        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FolderPath ResourceRoot 
            => LogRoot + ResoureFolder;

        /// <summary>
        /// The path to the resource index directory
        /// </summary>
        FolderPath ResIndexDir
            => ResourceRoot + ResIndexFolder;
            
        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FolderPath ExportRoot 
            => LogRoot + ExportFolder;

        /// <summary>
        /// The global capture archive root directory
        /// </summary>
        FolderPath CaptureRoot
            => LogRoot + RelativeLocation.Define("apps/control/capture");

        /// <summary>
        /// The runtime root
        /// </summary>
        FolderPath RuntimeRoot
            => LogRoot +  RuntimeLogFolder;

        /// <summary>
        /// The executing application's part identifier
        /// </summary>
        PartId AppId 
            => Part.ExecutingPart;

        /// <summary>
        /// The executing application's name
        /// </summary>
        string AppName 
            => AppId.Format();

        /// <summary>
        /// The executing application's folder name
        /// </summary>
        FolderName AppFolder
            => FolderName.Define(AppName);

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

        // /// <summary>
        // /// The build publication directory
        // /// </summary>
        // FolderPath BuildPub
        //     => ArchiveRoot + FolderName.Define("builds");        

        /// <summary>
        /// The directory into into which standard out stream emissions are deposited
        /// </summary>
        FolderPath AppStandardOut 
            => RuntimeRoot + StandardOutFolder;

        /// <summary>
        /// The path to the global test error log directory
        /// </summary>
        FolderPath AppErrorOut 
            => RuntimeRoot + ErrorOutFolder;

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName AppStandardOutName 
            => FileName.Define($"{AppName}.stdout", FileExtensions.Log);

        /// <summary>
        /// The executing application's standard out log filename
        /// </summary>
        FileName CaseLogName
            => FileName.Define($"{AppName}.cases", FileExtensions.Csv);

        /// <summary>
        /// The executing application's error log filename
        /// </summary>
        FileName AppErrorOutName 
            => FileName.Define($"{AppName}.errors", FileExtensions.Log);

        /// <summary>
        /// The executing application's data filename
        /// </summary>
        FileName AppDataFileName
            => FileName.Define($"{AppName}", FileExtensions.Csv);

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
            => (DevRoot +  SrcFolder) + AppFolder;

        /// <summary>
        /// The executing application's configuration file path
        /// </summary>
        FilePath AppConfigPath 
            => AppDevRoot + ConfigFileName;

        /// <summary>
        /// The executing application's data directory
        /// </summary>
        FolderPath AppDataRoot 
            => (LogRoot + RuntimeLogFolder) + AppFolder;

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
        /// The path to the global test error log directory
        /// </summary>
        FolderPath TestErrorOut 
            => TestLogRoot + ErrorOutFolder;

        FilePath TestErrorPath 
            => TestErrorOut + AppErrorOutName;

        FolderPath TestStandardOutDir 
            => TestLogRoot + StandardOutFolder;

        FilePath TestStandardPath 
            => TestStandardOutDir + AppStandardOutName;

        FilePath CaseLogPath
            => TestStandardOutDir + CaseLogName;

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath TestResults 
            => TestLogRoot + TestResultFolder;


        /// <summary>
        /// The name of the root bench partition
        /// </summary>
        FolderName BenchRootFolder 
            => FolderName.Define("bench");

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath BenchResults 
            => LogRoot + BenchRootFolder;

        /// <summary>
        /// The application-specific bench result file path
        /// </summary>
        FilePath BenchResultPath
            => BenchResults + FileName.Define($"{AppName}", FileExtensions.Csv);        
 
        /// <summary>
        /// Creates a provider rooted at the current root directory for another application
        /// </summary>
        /// <param name="dst">The target app id</param>
        TAppPaths ForApp(PartId dst)
            => AppPaths.init(dst, LogRoot);

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

        string ITextual.Format() 
            => AppName;

        /// <summary>
        /// The path to the captured x86 resource assembly
        /// </summary>
        FilePath ResBytes
            => FilePath.Define(@"K:\z0\archives\res\bin\lib\netcoreapp3.0\z0.res.dll");
    }
}