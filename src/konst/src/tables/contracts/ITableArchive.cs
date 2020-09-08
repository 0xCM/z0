//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Collections.Generic;
    using System.Linq;

    [SuppressUnmanagedCodeSecurity]
    public interface ITableArchive
    {
        FolderPath ArchiveRoot {get;}

        Option<FilePath> Deposit<F,R>(R[] src, FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Option<FilePath> Deposit<F,R>(R[] src, FolderName folder, FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        void Clear()
            => ArchiveRoot.Clear();

        void Clear(FolderName folder)
            => (ArchiveRoot + folder).Clear();

        ParseResult<TextDoc> Dataset(FilePath src)
            => TextDocParser.parse(src);

        ParseResult<TextDoc> Dataset(FileName name)
            => (from p in DatasetPaths().Where(p => p.FileName == name)
                select Dataset(p)).FirstOrDefault();

        ParseResult<TextDoc> Dataset(string name)
            => Dataset(ArchiveRoot + FileName.define(name, FileExtensions.Csv));

        IEnumerable<FilePath> DatasetPaths(FolderName subject = default)
            => (ArchiveRoot + (subject ?? FolderName.Define("asm"))).Files(FileExtensions.Csv, true);
    }
}