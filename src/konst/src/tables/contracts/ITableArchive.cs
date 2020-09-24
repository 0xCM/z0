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
    public interface ITableArchive : IFileDb
    {
        Option<FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Option<FilePath> Deposit<F,R>(R[] src, FS.FolderName folder, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        void Clear()
            => Root.Clear();

        void Clear(FS.FolderName folder)
            => (Root + folder).Clear();

        ParseResult<TextDoc> Dataset(FS.FilePath src)
            => TextDocParser.parse(src);

        ParseResult<TextDoc> Dataset(FS.FileName name)
            => (from p in DatasetPaths().Where(p => p.FileName == name)
                select Dataset(p)).FirstOrDefault();

        ParseResult<TextDoc> Dataset(string name)
            => Dataset(Root + FS.file(name, ArchiveExt.Csv));

        IEnumerable<FS.FilePath> DatasetPaths(FS.FolderName? subject = default)
            => (Root + (subject ?? FS.folder("asm"))).Files(ArchiveExt.Csv, true);
    }
}