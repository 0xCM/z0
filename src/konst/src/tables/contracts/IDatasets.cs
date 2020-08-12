//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDatasets : IDatasetArchive
    {
        FolderName IDatasetArchive.RootFolder 
            => FolderName.Define("pubs");

        FolderName DatasetFolder 
            => FolderName.Define("datasets");

        FolderPath IDatasetArchive.ArchiveRoot
            => Env.Current.LogDir + RootFolder;

        FileExtension DataFileExt 
            => FileExtensions.Csv;

        FolderPath DatasetDir 
            => ArchiveRoot + DatasetFolder;

        FilePath DatasetPath(string name)
            => DatasetDir + FileName.Define(name, DataFileExt);
    }
}