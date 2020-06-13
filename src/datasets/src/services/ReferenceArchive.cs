//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IReferenceArchive : IDatasetArchive
    {
        FolderName IDatasetArchive.RootFolder 
            => FolderName.Define("data");

        FolderPath IDatasetArchive.ArchiveRoot
            => Env.Current.DevDir + RootFolder;
    }

    public readonly struct ReferenceArchive : IReferenceArchive
    {
        public static IReferenceArchive Service => default(ReferenceArchive);        
    }
}