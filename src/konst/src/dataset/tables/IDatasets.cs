//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

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

        FilePath DatasetPath(string dsname)
            => DatasetDir + FileName.Define(dsname, DataFileExt);

        FilePath DatasetPath(IDataModel model)
            => DatasetDir + FileName.Define(model.Name, DataFileExt);
    }
}