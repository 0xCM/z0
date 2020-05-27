//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct PublicationArchive : IPublicationArchive
    {
        public static IPublicationArchive Default => default(PublicationArchive);        
    }    

    
    public interface IPublicationArchive : IDatasetArchive
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