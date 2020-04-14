//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppPaths : ICustomFormattable
    {
        /// <summary>
        /// The current assembly
        /// </summary>
        PartId AppId {get;}

        /// <summary>
        /// The application-wide root output directory
        /// </summary>
        FolderPath Root {get;}

        /// <summary>
        /// The test ro0t
        /// </summary>
        FolderPath TestRoot {get;}

        /// <summary>
        /// The system-wide root data directory
        /// </summary>
        FolderPath DataRoot {get;}

        /// <summary>
        /// The directory into wich error console streams are deposited
        /// </summary>
        FolderPath StandardOut {get;}

        /// <summary>
        /// The directory into standard  console streams are deposited
        /// </summary>
        FolderPath StandardError {get;}

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath TestResults {get;}

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath BenchResults {get;}

        FilePath StandardOutPath
            => StandardOut + FileName.Define($"{AppId.Format()}.stdout.log");

        FilePath StandardErrorPath
            => StandardOut + FileName.Define($"{AppId.Format()}.stderr.log");

        FolderName TestResultFolder => FolderName.Define("results");

        FolderPath TestDataRoot => TestRoot + FolderName.Define("data");

        FilePath TestResultPath
            => TestResults + FileName.Define($"{AppId.Format()}", FileExtensions.Csv);

        FilePath BenchResultPath
            => BenchResults + FileName.Define($"{AppId.Format()}", FileExtensions.Csv);

        FolderPath TestDataDir(Type test)
            => TestDataRoot +  FolderName.Define((test ?? GetType()).Name);

        FolderPath TestDataDir<T>()
            => TestDataDir(typeof(T));
        
        FolderPath ComponentDataDir(PartId owner, string subfolder = null)
            => (DataRoot + FolderName.Define(owner.Format())) + FolderName.Define(subfolder ?? string.Empty);
    }

    public interface IAppPaths<T> : IAppPaths,  IFormattable<T>
        where T : IAppPaths<T>
    {


    }
}