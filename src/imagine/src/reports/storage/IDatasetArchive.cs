//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IDatasetArchive
    {
        FolderPath ArchiveRoot {get;}

        FolderName RootFolder {get;}

        ParseResult<TextDoc> Dataset(FilePath src)
            => TextDocParser.parse(src);

        ParseResult<TextDoc> Dataset(FileName name)
            => (from p in DatasetPaths().Where(p => p.FileName == name)
                select Dataset(p)).FirstOrDefault(); 
              

        ParseResult<TextDoc> Dataset(string name)
            => Dataset(ArchiveRoot + FileName.Define(name, FileExtensions.Csv));

        IEnumerable<FilePath> DatasetPaths(FolderName subject = default)
            => (ArchiveRoot + (subject ?? FolderName.Define("asm"))).Files(FileExtensions.Csv, true);
    }
}