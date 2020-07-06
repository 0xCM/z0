//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface TReferenceArchive : IDatasetArchive
    {
        FolderName IDatasetArchive.RootFolder 
            => FolderName.Define("data");

        FolderPath IDatasetArchive.ArchiveRoot
            => Env.Current.DevDir + RootFolder;
    }

    public readonly struct ReferenceArchive : TReferenceArchive
    {
        public static TReferenceArchive Service => default;
    }
}