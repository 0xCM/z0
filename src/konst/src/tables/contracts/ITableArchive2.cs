//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface ITableArchive : IFileArchive
    {
        Option<FS.FilePath> Deposit<F,R>(R[] src, FS.FileName name)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        FS.FilePath TablePath(FS.FileName file)
            => Root + file;

        FS.FilePath[] Clear(FS.FolderName id)
            => (Root + id).Clear(root.list<FS.FilePath>()).ToArray();

        void Clear()
            => Root.Clear();
    }
}