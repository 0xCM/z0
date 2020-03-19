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
        AssemblyId AppId {get;}

        /// <summary>
        /// The application-wide root output directory
        /// </summary>
        FolderPath GlobalRootDir {get;}

        /// <summary>
        /// The system-wide root data directory
        /// </summary>
        FolderPath DataRootDir {get;}

        /// <summary>
        /// The directory into wich error console streams are deposited
        /// </summary>
        FolderPath StandardOutDir {get;}

        /// <summary>
        /// The directory into standard  console streams are deposited
        /// </summary>
        FolderPath StandardErrorDir {get;}

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath TestResultDir {get;}

        /// <summary>
        /// The directory into which structured data describing test results are deposited
        /// </summary>
        FolderPath BenchResultDir {get;}

        FilePath StandardOutPath
            => StandardOutDir + FileName.Define($"{AppId.Format()}.stdout.log");

        FilePath StandardErrorPath
            => StandardOutDir + FileName.Define($"{AppId.Format()}.stderr.log");

        FilePath TestResultPath
            => TestResultDir + FileName.Define($"{AppId.Format()}", FileExtensions.Csv);

        FilePath BenchResultPath
            => BenchResultDir + FileName.Define($"{AppId.Format()}", FileExtensions.Csv);

        FolderPath TestDataDir(Type test)
            => StandardOutDir +  FolderName.Define((test ?? GetType()).Name);

        FolderPath TestDataDir<T>()
            => TestDataDir(typeof(T));
        
        FolderPath ComponentDataDir(AssemblyId owner, string subfolder = null)
            => (DataRootDir + FolderName.Define(owner.Format())) + FolderName.Define(text.denullify(subfolder));
    }

    public interface IAppPaths<T> : IAppPaths,  IFormattable<T>
        where T : IAppPaths<T>
    {


    }
}