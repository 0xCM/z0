//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Reifies default application path service
    /// </summary>
    public readonly struct AppPaths : IAppPaths
    {
        public PartId AppId {get;}

        public FolderPath Root {get;}

        [MethodImpl(Inline)]
        public static IAppPaths Create(PartId id, FolderPath root = null)
            => new AppPaths(id, root ?? Env.Current.LogDir);

        public static IAppPaths Default => Create(ExecutingApp);

        [MethodImpl(Inline)]
        AppPaths(PartId id, FolderPath root)
        {
            this.AppId = id;
            this.Root = root;
        }
    }

    public interface IAppPaths : ITextual
    {
        /// <summary>
        /// The application part identifier
        /// </summary>
        PartId AppId => ExecutingApp;

        /// <summary>
        /// The application-wide root output directory
        /// </summary>
        FolderPath Root => Env.Current.LogDir;

        /// <summary>
        /// The default application configuration file filename
        /// </summary>
        FileName ConfigFileName => FileName.Define("config.json");

        /// <summary>
        /// The application name
        /// </summary>
        string AppName => AppId.Format();

        /// <summary>
        /// The name of the root test partition
        /// </summary>
        FolderName TestRootFolder => FolderName.Define("test");

        /// <summary>
        /// The root test directory
        /// </summary>
        FolderPath TestRoot => Root + TestRootFolder;

        /// <summary>
        /// The root folder for test-specific data
        /// </summary>
        FolderPath TestDataRoot => TestRoot + FolderName.Define("data");

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
        FolderPath TestDataDir<T>() => TestDataDir(typeof(T));

        /// <summary>
        /// The name of the folder into which standard out stream emissions during test execution are deposited
        /// </summary>
        FolderName StandardOutFolder => FolderName.Define("stdout");

        /// <summary>
        /// The directory into into which standard out stream emissions are deposited
        /// </summary>
        FolderPath StandardOut => TestRoot + StandardOutFolder;

        /// <summary>
        /// The application-specific standard out stream log path
        /// </summary>
        FilePath StandardLogPath => StandardOut + FileName.Define($"{AppName}.stdout", FileExtensions.Log);

        /// <summary>
        /// The name of the folder into which error stream emissions are deposited
        /// </summary>
        FolderName ErrorOutFolder => FolderName.Define("errors");

        /// <summary>
        /// The directory into which error stream emissions during test execution are deposited
        /// </summary>
        FolderPath ErrorOut => TestRoot + ErrorOutFolder;

        /// <summary>
        /// The application-specific error stream log path
        /// </summary>
        FilePath ErrorLogPath => ErrorOut + FileName.Define($"{AppName}.errors", FileExtensions.Log);

        /// <summary>
        /// The name of the folder into which test results are deposited
        /// </summary>
        FolderName TestResultFolder => FolderName.Define("results");

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath TestResults => TestRoot + TestResultFolder;

        /// <summary>
        /// The application-specific test result file path
        /// </summary>
        FilePath TestResultPath
            => TestResults + FileName.Define($"{AppName}", FileExtensions.Csv);

        /// <summary>
        /// The name of the root app partition
        /// </summary>
        FolderName DataRootFolder => FolderName.Define("data");

        /// <summary>
        /// The root data directory
        /// </summary>
        FolderPath DataRoot => Root + DataRootFolder;

        /// <summary>
        /// The name of the root bench partition
        /// </summary>
        FolderName BenchRootFolder => FolderName.Define("bench");

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath BenchResults => Root + BenchRootFolder;

        /// <summary>
        /// The application-specific bench result file path
        /// </summary>
        FilePath BenchResultPath
            => BenchResults + FileName.Define($"{AppName}", FileExtensions.Csv);        

        /// <summary>
        /// The name of the root app partition
        /// </summary>
        FolderName AppRootFolder => FolderName.Define("apps");

        /// <summary>
        /// The path to the root development directory
        /// </summary>
        FolderPath DevRoot => Env.Current.DevDir;

        /// <summary>
        /// The application-relative source code directory
        /// </summary>
        FolderPath AppSrcPath => DevRoot + RelativeLocation.Define($"src/{AppName}");

        /// <summary>
        /// The appliction-relative source file generation target directory
        /// </summary>
        FolderPath GenSrcDir => AppSrcPath + FolderName.Define("generated");

        /// <summary>
        /// The application-relative configuration path
        /// </summary>
        FilePath AppConfigPath => AppSrcPath + ConfigFileName;

        /// <summary>
        /// The application-relative data directory
        /// </summary>
        FolderPath AppDataPath => Root + RelativeLocation.Define($"apps/{AppName}");        

        /// <summary>
        /// The name of the folder into which capture results are deposited
        /// </summary>
        FolderName CaptureFolder => FolderName.Define("capture");        

        /// <summary>
        /// The application-relative capture directory
        /// </summary>
        FolderPath AppCapturePath => AppDataPath + CaptureFolder;

        /// <summary>
        /// Creates a provider rooted at the current root directory for another application
        /// </summary>
        /// <param name="dst">The target app id</param>

        [MethodImpl(Inline)]
        IAppPaths ForApp(PartId dst)
            => AppPaths.Create(dst, Root);

        string ITextual.Format() => AppName;
    }
}