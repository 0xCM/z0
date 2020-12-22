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

    using static Konst;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using X = FileExtensions;

    [Free]
    public interface ITableArchive : IFileArchive
    {
        Option<FS.FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Option<FS.FilePath> Deposit<F,R>(R[] src, FS.FolderName folder, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        FS.FilePath TablePath(FS.FileName file)
            => Root + file;

        FS.FilePath TablePath(FS.FolderName folder, FS.FileName file)
            => Root + folder + file;

        new FS.FilePath[] Clear(FS.FolderName id)
            => (Root + id).Clear(z.list<FS.FilePath>()).ToArray();

        void Clear()
            => Root.Clear();

        ParseResult<TextDoc> Dataset(FS.FilePath src)
            => TextDocParser.parse(src);

        ParseResult<TextDoc> Dataset(FS.FileName name)
            => (from p in DatasetPaths().Where(p => p.FileName == name)
                select Dataset(p)).FirstOrDefault();

        ParseResult<TextDoc> Dataset(string name)
            => Dataset(Root + FS.file(name, X.Csv));

        IEnumerable<FS.FilePath> DatasetPaths(FS.FolderName? subject = default)
            => (Root + (subject ?? FS.folder("asm"))).Files(X.Csv, true);
    }

    public interface ITableArchive<R>
        where R : struct
    {
        Option<FS.FilePath> Save(R[] src, TableRenderSpec format, FS.FilePath dst, FileWriteMode mode = Overwrite);
    }

    public interface IDatasetArchive<F,R> : ITableArchive<R>
        where F : unmanaged
        where R : struct
    {
        Option<FS.FilePath> Save(R[] src, TableRenderSpec<F> format, FS.FilePath dst, FileWriteMode mode = Overwrite);

        Option<FS.FilePath> ITableArchive<R>.Save(R[] src, TableRenderSpec format, FS.FilePath dst, FileWriteMode mode)
            => Save(src, format, dst, mode);

        /// <summary>
        /// Saves tabular data using derived metadata for format configuration
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target file</param>
        /// <typeparam name="R">The source type</typeparam>
        Option<FS.FilePath> Save(R[] src, FS.FilePath dst);
    }
}