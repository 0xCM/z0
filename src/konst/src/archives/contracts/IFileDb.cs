//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface IFileDb : IFileArchive
    {
        FS.FolderPath TableRoot
            => Root + FS.folder("tables");

        FS.FolderPath IndexRoot
            => Root + FS.folder("index");

        FS.FilePath Table(string schema, string name, FS.FileExt? ext = null)
            => TableRoot + FS.file(text.format("{0}.{1}", schema,name), ext ?? GlobalExtensions.Csv);

        FS.FilePath File(FS.FileName file)
            => TableRoot + file;

    }

    public interface IFileDbHost<H> : IFileDb
        where H : IFileDbHost<H>
    {

    }
}