//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    public interface IDatasetArchive
    {
        FolderPath ArchiveRoot {get;}

        FolderName RootFolder {get;}

        Option<TextDoc> Dataset(FilePath src)
            => src.ReadTextDoc();

        Option<TextDoc> Dataset(string name)
            => Dataset(ArchiveRoot + FileName.Define(name, FileExtensions.Csv));

        IEnumerable<FilePath> DatasetPaths(FolderName subject = default)
            => (ArchiveRoot + (subject ?? FolderName.Define("asm"))).Files(FileExtensions.Csv, true);
    }
}