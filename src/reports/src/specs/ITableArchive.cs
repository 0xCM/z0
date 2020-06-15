//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableArchive
    {
        FolderPath ArchiveRoot {get;}            
        
        Option<FilePath> Deposit<R>(R[] src, FileName name)
            where R : ITabular;

        Option<FilePath> Deposit<R>(R[] src, FolderName folder, FileName name)
            where R : ITabular;

        void Clear()
            => ArchiveRoot.Clear();
        
        void Clear(FolderName folder)
            => (ArchiveRoot + folder).Clear();
    }
}